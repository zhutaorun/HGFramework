--region *.lua
--Date
--此文件由[BabeLua]插件自动生成

require "Framework/FSM.lua"
require "Demo/Fight/FightHeroFSM/FightHeroIdleState.lua"
require "Demo/Fight/FightHeroFSM/FightHeroMoveState.lua"
require "Demo/Fight/FightHeroFSM/FightHeroAttackState.lua"

FightHero = class("FightHero");

function FightHero:Awake()
    self.mNavMeshAgent = self.gameObj:GetComponent("NavMeshAgent");
    self.animation = self.gameObj:GetComponent("Animation");

    --新状态机框架
    self.mFSM = FSM:new();
    --添加状态
    local idleState = self.mFSM:AddState(FightHeroIdleState:new("FightHeroIdleState", self));
    local moveState = self.mFSM:AddState(FightHeroMoveState:new("FightHeroMoveState", self));
    local attackState = self.mFSM:AddState(FightHeroAttackState:new("FightHeroAttackState", self));
    --为状态添加跳转
    self.mFSM:AddTranslation(idleState, "Move", moveState);
    self.mFSM:AddTranslation(idleState, "Attack", attackState);
    self.mFSM:AddTranslation(moveState, "Finish", idleState);
    self.mFSM:AddTranslation(moveState, "Move", moveState);
    self.mFSM:AddTranslation(moveState, "Attack", attackState);
    self.mFSM:AddTranslation(attackState, "Finish", idleState);
    --启动状态机
    self.mFSM:Start(idleState);
end

function FightHero:Update()
    self.mFSM:Update();
end

function FightHero:HandleMsg(msg, ...)
    if msg == "MOVE_MSG" then
        self.mFSM:HandleEvent("Move", ...);       
    elseif msg == "ATTACK_MSG" then
        self.mFSM:HandleEvent("Attack", ...);
    end
end

--endregion
