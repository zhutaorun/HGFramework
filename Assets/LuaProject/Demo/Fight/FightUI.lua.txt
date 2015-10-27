--region *.lua
--Date
--此文件由[BabeLua]插件自动生成

FightUI = class("FightUI");

function FightUI:Awake()
    heroInfo = Config.GetHeroInfoConfig(data.selectHeroID);
    self.nameLabel = self.trans:Find("HeroInfo/NameLabel"):GetComponent("UILabel");
    self.nameLabel.text = heroInfo.name;
    self.hpProgressBar = self.trans:Find("HeroInfo/HPProgressBar"):GetComponent("UISlider");
    self.mpProgressBar = self.trans:Find("HeroInfo/MPProgressBar"):GetComponent("UISlider");
end

--endregion
