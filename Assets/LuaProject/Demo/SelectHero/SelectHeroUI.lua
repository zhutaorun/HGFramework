--region *.lua
--Date
--此文件由[BabeLua]插件自动生成
require "Demo/Fight/FightSceneLoading.lua"

local GameObject = UnityEngine.GameObject;

--选择英雄UI
SelectHeroUI = class("SelectHeroUI");

function SelectHeroUI:Awake()
	--查找子UI
	self.nameLabel = self.trans:Find("Info/NameLabel"):GetComponent("UILabel");
	self.attackLabel = self.trans:Find("Info/AttackValueLabel"):GetComponent("UILabel");
	self.defendLabel = self.trans:Find("Info/DefendValueLabel"):GetComponent("UILabel");
	self.descriptionLabel = self.trans:Find("Info/DescriptionLabel"):GetComponent("UILabel");
    UIEventListenerWrapper.AddOnClick(self.trans:Find("EnterGameButton").gameObject, self, self.OnEnterGameButtonClick);
	--注册点击模型事件
	MsgDispatcher.RegLogicMsg("SelectHero", self, self.HandleSelectHeroMsg);
end

function SelectHeroUI:HandleSelectHeroMsg(arg)
	local hero = Config.GetHeroInfoConfig(arg["id"]);
	self.nameLabel.text = hero.name;
	self.attackLabel.text = hero.attack;
	self.defendLabel.text = hero.defend;
	self.descriptionLabel.text = hero.description;
end

function SelectHeroUI:OnEnterGameButtonClick(btnGO)
    --进入游戏场景
    if data.selectHeroID then
        Utility.CreateLuaBehaviour(GameObject("FightSceneLoading"), FightSceneLoading:new()); 
    end
end

--endregion
