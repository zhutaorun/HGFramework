--region *.lua
--Date
--此文件由[BabeLua]插件自动生成

FightHeroInfo = class("FightHeroInfo")

function FightHeroInfo:Awake()
    self.headSprite = self.trans:Find("HeadSprite"):GetComponent("UISprite");
    self.nameLabel = self.trans:Find("NameLabel"):GetComponent("UILabel");
    self.hpProgressBar = self.trans:Find("HPProgressBar"):GetComponent("UISlider");
    self.mpProgressBar = self.trans:Find("MPProgressBar"):GetComponent("UISlider");
end

--endregion
