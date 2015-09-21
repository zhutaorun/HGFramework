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
    local loading = Utility.CreateLuaBehaviour(GameObject.Find("Loading"), Loading:new());
	loading:Show(); 
end

function FightSceneLoading:OnSceneLoadDone(sceneName)
    MsgDispatcher.SendLogicMsg("SceneLoadDone");
    Utility.CreateLuaBehaviour(GameObject.Find("Scene"), FightScene:new());
    Utility.CreateLuaBehaviour(GameObject.Find("UI"), FightUI:new());
end

function FightSceneLoading:OnSceneLoadUpdate(sceneName, progress)
    
end

--endregion
