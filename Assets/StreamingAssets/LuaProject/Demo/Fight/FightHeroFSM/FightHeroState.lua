--region *.lua
--Date
--此文件由[BabeLua]插件自动生成

FightHeroState = class("FightHeroState");

function FightHeroState:initialize(fsm)
    self.fsm = fsm;
end

function FightHeroState:OnEnter(args)
    
end

function FightHeroState:OnReEnter(args)

end

function FightHeroState:OnUpdate(args)
    
end

function FightHeroState:OnExit(args)
    
end

function FightHeroState:HandleMoveHeroMsg(args)
    self.fsm:Translate("Move", args);
end

function FightHeroState:HandleMsg(msg, ...)
    if msg == "Move" then
        self.fsm:Translate(self.fsm.moveState, ...);
    elseif msg == "Attack" then
        self.fsm:Translate(self.fsm.attackState, ...);
    end
end

--endregion
