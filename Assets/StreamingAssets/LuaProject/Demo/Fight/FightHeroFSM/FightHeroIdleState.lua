--region *.lua
--Date
--此文件由[BabeLua]插件自动生成
require "Demo/Fight/FightHeroFSM/FightHeroState.lua"

FightHeroIdleState = class("FightHeroIdleState", FightHeroState);

function FightHeroIdleState:OnEnter(...)
    self.mHero.animation:Play("idle");
end

--endregion
