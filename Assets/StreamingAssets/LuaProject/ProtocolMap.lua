--region *.lua
--Date
--此文件由[BabeLua]插件自动生成

require "Protocol/share_ttypes.lua"
require "Protocol/login_ttypes.lua"

ProtocolMap = {};

function Challenge:GetType()
    return 40419;
end

function C2SLogin:GetType()
    return 79729;
end

function S2CLogin:GetType()
    return 89713;
end

function ProtocolMap.NewMsg(msgType)
    if msgType == 40419 then
        return Challenge:new{};
    elseif msgType == 89713 then
        return S2CLogin:new{};
    elseif msgType == 21718 then
        return LoginRepeatNotice:new{};
    end
end

--endregion
