--region *.lua
--Date
--此文件由[BabeLua]插件自动生成

FightHeroAttackState = class("FightHeroAttackState", FightHeroState);

function FightHeroAttackState:OnEnter(...)
    self.mHero.animation:Play("attack1");
    local delay = self.mHero.animation:GetClip("attack1").length * 1000;
    -- 回滚到idle状态
    LuaTimer.Add(delay, function ()
        self.mHero.mFSM:HandleEvent("Finish");
    end);
end

--endregion
