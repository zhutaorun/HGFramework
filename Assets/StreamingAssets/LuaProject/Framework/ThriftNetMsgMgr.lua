--region *.lua
--Date
--此文件由[BabeLua]插件自动生成

require "ProtocolMap.lua"

local Debug = UnityEngine.Debug;

NetMsgMgr = {};

NetMsgMgr.mNetMsgHandlerDict = {};

--发送网络消息，提供给逻辑模块的接口
--msg: 消息数据对象，用于TLV中的V的序列化
function NetMsgMgr.SendNetMsg(msg)
    if msg == nil then
        print("_SendNetMsg is nil");
        return;
    end
    local msgType = msg:GetType();
    --序列化消息对象
    local trans = TMemoryBuffer:new{};
    local proto = TBinaryProtocol:new{ trans = trans };
    msg:write(proto);
    local msgData = trans:getBuffer();
    --交由网络发送消息线程发送
    NetMgr.Instance():SendNetMsg(msgType, msgData);
end

--发送通道网络消息，提供给逻辑模块的接口
--msg: 消息数据对象，用于TLV中的V的序列化
function NetMsgMgr.SendNetChannelMsg(msg)
    if msg == nil then
        print("_SendNetChannelMsg is nil");
        return;
    end
    local requestMsg = ClientChannelRequest:new{};
    requestMsg.internalProtocolType = msg:GetType();
    local trans = TMemoryBuffer:new{};
    local proto = TBinaryProtocol:new{ trans = trans };
    msg:write(proto);
    requestMsg.content = trans:getBuffer();
    NetMsgMgr.SendNetMsg(requestMsg);
end

--处理接收到的网络消息，提供给c#框架的接口
--msgType: 消息类型，用于解析并实例化消息对象
--msgData: 消息数据，用于消息对象的反序列化
--TODO 反序列化消息是耗时操作，可考虑用协程方式优化
function NetMsgMgr.HandleNetMsg(msgType, msgData)
    --根据类型实例化消息对象
    local msg = _NewMsg(msgType);
	if msgType == ClientChannelResponse:GetType() then
		local t = TMemoryBuffer:new{};
		t:resetBuffer(msgData);
		local p = TBinaryProtocol:new{ trans = t };
		msg:read(p);
		msgType = msg.internalProtocolType;
		msgData = msg.content;
		msg = _NewMsg(msg.internalProtocolType);
	end
    --反序列化消息
    local trans = TMemoryBuffer:new{};
    trans:resetBuffer(msgData);
    local proto = TBinaryProtocol:new{ trans = trans };
    msg:read(proto);
	--输出协议日志
	print(NetMsgMgr.ParseMsg(msg));
    --交由逻辑处理
    local handlers = NetMsgMgr.mNetMsgHandlerDict[msgType];
    if handlers then
        print("Handle : " .. msgType);
        for i = 1, #handlers do
            local handler = handlers[i];
            --如果有self，则表示是对象的回调处理
            if handler.self then
                handler.callback(handler.self, msg);
            else
                handler.callback(msg);
            end
        end
    end
end

--注册网络消息处理回调
function NetMsgMgr.RegNetMsgHandler(msgType, self, callback)
    if NetMsgMgr.mNetMsgHandlerDict[msgType] == nil then
        NetMsgMgr.mNetMsgHandlerDict[msgType] = {};
    end
    local handler = 
    {
        self = self,
        callback = callback,
    };
    Debug.LogWarning("RegNetMsgHandler : " .. msgType);
    table.insert(NetMsgMgr.mNetMsgHandlerDict[msgType], handler);
end

--解注册网络消息处理回调
function NetMsgMgr.UnRegNetMsgHandler(msgType, self, callback)
    local handlers = NetMsgMgr.mNetMsgHandlerDict[msgType];
    if handlers == nil then
        print("NOT Register!");
        return;
    end
    for i = #handlers, 1, -1 do
        local handler = handlers[i];
        if handler.self == self and handler.callback == callback then
            Debug.LogWarning("UnRegNetMsgHandle : " .. msgType);
            table.remove(handlers, i);
            break;
        end
    end
end

--输出协议
function NetMsgMgr.ParseMsg(msg)
	if msg == nil then
		return;
	end
	local str = "";
	--输出数组部分
	str = str .. "[";
	for i,v in ipairs(msg) do
		local t = type(v);
		if t == "string" or t == "number" or t == "boolean" then
			str = str .. v;
		elseif t == "table" then
			str = str .. NetMsgMgr.ParseMsg(msg);
		end
		str = str .. ",";
	end
	str = str .. "],{";
	--输出字典部分
	for k,v in pairs(msg) do
		if not string.find(k, "__") then
			str = str .. "{" .. k .. ":";
			local t = type(v);
			if t == "string" or t == "number" or t == "boolean" then
				str = str .. v;
			elseif t == "table" then
				str = str .. NetMsgMgr.ParseMsg(msg);
			end
			str = str .. "},";
		end
	end
	str = str .. "}";
	return str;
end

--endregion
