--region *.lua
--Date
--此文件由[BabeLua]插件自动生成

require "Demo/Login/LoginUI.lua"

LoginSceneLoading = class("LoginSceneLoading");

function LoginSceneLoading:Awake(...)
    local args = {...};
    local scene = args[1];
    print("Enter Scene : " .. scene .. " args : " .. args[2]);
    local logicRes = {};
    SceneMgrWrapper.EnterScene("loading.scene", self, self.OnLoadingDone, 
		"login.scene", logicRes, self, self.OnSceneLoadDone, self.OnSceneLoadUpdate);
end

--Loading场景加载完成
function LoginSceneLoading:OnLoadingDone()
	local loadingUI = _CreateLuaBehaviour(GameObject.Find("LoadingUI"), LoadingUI:new());
	loadingUI:Show();
end

--游戏场景加载完成
function LoginSceneLoading:OnSceneLoadDone(sceneName)
	--新场景逻辑
	_SendLogicMsg("SceneLoadDone");
	_CreateLuaBehaviour(GameObject.Find("UI"), LoginUI:new());
end

function LoginSceneLoading:OnSceneLoadUpdate(sceneName, progress)
	print(sceneName .. " " .. progress);
end

--endregion
