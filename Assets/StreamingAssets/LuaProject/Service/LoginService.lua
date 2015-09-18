--region *.lua
--Date
--此文件由[BabeLua]插件自动生成

require "ProtocolMap.lua"

LoginService = {};

function LoginService.Login()
    local loginMsg = C2SLogin:new
    {
        pid = "22",
        channel = "test",
        zoneId = "test", 
    };
    _SendNetMsg(loginMsg);
end

--endregion
