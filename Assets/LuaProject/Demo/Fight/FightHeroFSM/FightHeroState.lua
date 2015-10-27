--region *.lua
--Date
--此文件由[BabeLua]插件自动生成

FightHeroState = class("FightHeroState", FSMState);

function FightHeroState:initialize(name, hero)
    FSMState.initialize(self, name);
    self.mHero = hero;
end

--endregion
