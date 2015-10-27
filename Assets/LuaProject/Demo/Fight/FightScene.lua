--region *.lua
--Date
--此文件由[BabeLua]插件自动生成
require "Demo/Fight/PCCtrl.lua"
require "Demo/Fight/CameraCtrl.lua"
require "Demo/Fight/FightHero.lua"

local GameObject = UnityEngine.GameObject;

--战斗场景加载器
FightScene = class("FightScene");

function FightScene:Awake()
    self.camera = self.trans:Find("Main Camera"):GetComponent("Camera");
    heroInfo = Config.GetHeroInfoConfig(data.selectHeroID);
    local heroGO = GameObject.Instantiate(SceneMgrWrapper.GetResObj(ResMgrWrapper.GetHeroModelPath(heroInfo.model)));
    heroGO.name = "Hero";
    self.hero = Utility.CreateLuaBehaviour(heroGO, FightHero:new());
    --注册操作控制器，根据不同平台注册不同的操作控制器
    self.controller = PCCtrl:new(self.camera, self.hero);
    self.mCameraCtrl = CameraCtrl:new(self.camera, self.hero.trans);
end

function FightScene:Update()
    self.controller:Update();
    self.mCameraCtrl:Update();
end

--endregion
