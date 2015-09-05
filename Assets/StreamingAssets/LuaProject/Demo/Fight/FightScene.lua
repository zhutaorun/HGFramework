--region *.lua
--Date
--此文件由[BabeLua]插件自动生成
require "Demo/Fight/PCController.lua"
require "Demo/Fight/FightHero.lua"

--战斗场景加载器
FightScene = class("FightScene");

function FightScene:Awake()
    self.camera = self.trans:Find("Main Camera"):GetComponent("Camera");
    heroInfo = Config.GetHeroInfoConfig(data.selectHeroID);
    local heroGO = GameObject.Instantiate(LuaSceneMgr.GetResObj(LuaResMgr.GetHeroModelPath(heroInfo.model)));
    heroGO.name = "Hero";
    self.hero = Utility.CreateLuaBehaviour(heroGO, FightHero:new());
    --注册操作控制器，根据不同平台注册不同的操作控制器
    self.controller = PCController:new(self.camera, hero);
    --关联hero和camera
    self.controller:Init(self.camera, self.hero);
end

function FightScene:Update()
    self.controller:Update();
end

--endregion
