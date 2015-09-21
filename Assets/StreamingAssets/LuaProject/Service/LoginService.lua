--region *.lua
--Date
--此文件由[BabeLua]插件自动生成

require "ProtocolMap.lua"

LoginService = {};

function LoginService.Init()
    _RegNetMsgHandler(S2CLogin:GetType(), LoginService.HandleS2CLoginMsg);
end

function LoginService.Login(username)
    local loginMsg = C2SLogin:new
    {
        pid = username,
        channel = "test",
        zoneId = "test", 
    };
    _SendNetMsg(loginMsg);
end

function LoginService.HandleS2CLoginMsg(msg)
    print("status : " .. msg.loginStatus);
    Utility.CreateLuaBehaviour(GameObject("SelectHeroSceneLoading"), SelectHeroSceneLoading:new());
end

--endregion
