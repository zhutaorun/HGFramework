--region *.lua
--Date
--此文件由[BabeLua]插件自动生成
require "Demo/Fight/FightHeroFSM/FightHeroState.lua"

FightHeroMoveState = class("FightHeroMoveState", FightHeroState);

function FightHeroMoveState:OnEnter(args)
    self.fsm.animation:Play("walk");
    self.targetPos = args;
    self.fsm.mNavMeshAgent.updateRotation = true;
    self.fsm.mNavMeshAgent.destination = self.targetPos;
end

function FightHeroMoveState:OnUpdate(args)
    if self.fsm.mNavMeshAgent.remainingDistance < 0.01 then
        self.fsm:Translate("Idle");
    end
end

--endregion
