--region *.lua
--Date
--此文件由[BabeLua]插件自动生成

require "ProtocolMap.lua"

ThriftNetMsgMgr = {};

--发送网络消息，提供给逻辑模块的接口
--msg: 消息数据对象，用于TLV中的V的序列化
function _SendNetMsg(msg)
    if msg == nil then
        print("ThriftNetMsgMgr.SendNetMsg is nil");
        return;
    end
    local msgType = msg:GetType();
    local trans = TMemoryBuffer:new{};
    local proto = TBinaryProtocol:new{ trans = trans };
    msg:write(proto);
    local msgData = trans:getBuffer();
    --交由网络发送消息线程发送
    NetMgr.Instance():SendNetMsg(msgType, msgData);
end

--发送通道网络消息，提供给逻辑模块的接口
--msg: 消息数据对象，用于TLV中的V的序列化
function _SendNetChannelMsg(msg)
    if msg == nil then
        print("ThriftNetMsgMgr.SendNetChannelMsg is nil");
        return;
    end
    local requestMsg = ClientChannelRequest:new();
    requestMsg.internalProtocolType = msgType:GetType();
    local trans = TMemoryBuffer:new();
    local proto = TBinaryProtocol:new{ trans = trans };
    msg:write(proto);
    requestMsg.content = trans:getBuffer();
    ThriftNetMsgMgr.SendNetMsg(requestMsg);
end

--处理接收到的网络消息，提供给c#框架的接口
--msgType: 消息类型，用于解析并实例化消息对象
--msgData: 消息数据，用于消息对象的反序列化
--TODO 反序列化消息是耗时操作，可考虑用协程方式优化
function _HandleNetMsg(msgType, msgData)
    local msg = _NewMsg(msgType);
    local trans = TMemoryBuffer:new{};
    trans:resetBuffer(msgData);
    local proto = TBinaryProtocol:new{ trans = trans };
    msg:read(proto);
    --TEST交由逻辑处理
    if msgType == 21718 then
        print(msg.pUserId);
    elseif msgType == 89713 then
        print(msg.loginStatus);
    end
end

--endregion
