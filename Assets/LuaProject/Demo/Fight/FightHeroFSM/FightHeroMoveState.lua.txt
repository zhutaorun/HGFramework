--region *.lua
--Date
--此文件由[BabeLua]插件自动生成
require "Demo/Fight/FightHeroFSM/FightHeroState.lua"

FightHeroMoveState = class("FightHeroMoveState", FightHeroState);

function FightHeroMoveState:OnEnter(...)
    local args = {...};
    self.mHero.animation:Play("walk");
    self.targetPos = args[1];
    self.mHero.mNavMeshAgent.updateRotation = true;
    self.mHero.mNavMeshAgent.destination = self.targetPos;
    self.mHero.mNavMeshAgent:Resume();
end

function FightHeroMoveState:OnUpdate()
    
    if self.mHero.mNavMeshAgent.remainingDistance < 0.01 then
        self.mHero.mFSM:HandleEvent("Finish");
    end
end

function FightHeroMoveState:OnExit(...)
    self.mHero.mNavMeshAgent:Stop();
end

--endregion
