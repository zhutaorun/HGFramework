--region *.lua
--Date
--此文件由[BabeLua]插件自动生成
require "Demo/Fight/FightScene.lua"
require "Demo/Fight/FightUI.lua"

FightSceneLoading = class("FightSceneLoading");

function FightSceneLoading:Awake()
    heroInfo = Config.GetHeroInfoConfig(data.selectHeroID);
    logicRes = { ResMgrWrapper.GetHeroModelPath(heroInfo.model) };
    SceneMgrWrapper.EnterScene("loading.scene", self, self.OnLoadingDone,
        "fight.scene", logicRes, self, self.OnSceneLoadDone, self.OnSceneLoadUpdate);
end

function FightSceneLoading:OnLoadingDone()
    local loadingUI = _CreateLuaBehaviour(GameObject.Find("LoadingUI"), LoadingUI:new());
	loadingUI:Show(); 
end

function FightSceneLoading:OnSceneLoadDone(sceneName)
    _SendLogicMsg("SceneLoadDone");
    _CreateLuaBehaviour(GameObject.Find("Scene"), FightScene:new());
    _CreateLuaBehaviour(GameObject.Find("UI"), FightUI:new());
end

function FightSceneLoading:OnSceneLoadUpdate(sceneName, progress)
    
end

--endregion
