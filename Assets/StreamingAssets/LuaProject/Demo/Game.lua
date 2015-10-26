--全局头文件
class = require "Lib/MiddleClass/middleclass.lua"
json = require "cjson"
require "Lib/Thrift/TMemoryBuffer.lua"
require "Lib/Thrift/TBinaryProtocol.lua"
require "Framework/Utility.lua"
require "Framework/MsgDispatcher.lua"
require "Framework/ThriftNetMsgMgr.lua"
require "Wrapper/UIEventListenerWrapper.lua"
require "Wrapper/ResMgrWrapper.lua"
require "Wrapper/SceneMgrWrapper.lua"
require "AutoGeneration/Config/Config.lua"

require "Service/LoginService.lua"

require "Demo/LoadingUI.lua"
require "Demo/Login/LoginSceneLoading.lua"
require "Demo/SelectHero/SelectHeroSceneLoading.lua"

data = {};

local GameObject = UnityEngine.GameObject;
local Debug = UnityEngine.Debug;

function main()
	--测试cjson
	local json_text = '["Skill",{"skillID":"123","casterID":"234","BulletBehavior":{"behaviorID":"222","exeEffects":[["ShangHai",{"targetID":"888","val":100}],["ZhuoShao",{"targetID":"888","val":20,"round":2}]],"triEffects":[["DunShu",{"targetID":"888","val":80}]],"removedEffectIDs":["233","111"]}}]';
	local value = json.decode(json_text);	
	local skill = value[2];
	Debug.LogWarning("*****************" .. skill.behavior.behaviorID);
	for k,v in ipairs(skill.behavior.exeEffects) do
		Debug.LogWarning("-----------------------" .. v[1]);
	end
	
	local gameGO = GameObject.Find("Game");
	local colliders = gameGO:GetComponentsInChildren("UnityEngine.BoxCollider, UnityEngine");
	for i = 1, #colliders do
		Debug.LogWarning("@@@@@@ : " .. colliders[i].name);
	end
	
	local go = GameObject();
	
	local behavior = skill.behavior;
	local exeEffects = behavior.exeEffects;
	Debug.LogWarning(exeEffects[1][1] .. ", " .. exeEffects[2][1]);
	local str= json.encode(value);
	Debug.LogWarning(value[2]);

	--测试thrift格式的配置表
	Config.Load();

--    _CreateLuaBehaviour(GameObject("SelectHeroSceneLoading"), SelectHeroSceneLoading:new(), "select_hero.scene", "aaa");

    --网络消息注册
    --LoginService.Init();
	--测试网络demo
    Utility.CreateLuaBehaviour(GameObject("LoginSceneLoading"), LoginSceneLoading:new(), "login.scene", "aaa");
    --NetMgr.Instance():Connect("192.168.0.22", 8083);
	
	
end





Skill = class("Skill");

function Skill:initialize(skillData)
	self.skillID = skillData.skillID;
	self.casterID = skillData.casterID;
	--TODO 根据Behavior类型实例化不同的Behavior
	if skillData.BulletBehavior then
		self.behavior = BulletBehavior:new(skillData.BulletBehavior);
	else
		
	end
end



BaseBehavior = class("BaseBehavior");

function BaseBehavior:initialize(behaviorData)
	self.exeEffects = self:ParseEffects(self.exeEffects);
	self.triEffects = self:ParseEffects(self.triEffects);
	--TODO 删除的效果id列表
	self.removedEffectIDs = {};
end

function BaseBehavior:ParseEffects(effectsData)
	if effectsData == nil then
		return nil;
	end
	
	local effects = {};
	for i = 1, #effectsData do
		local effectData = effectsData[i];
		if effectData.ShangHai then
			table.insert(effects, ShangHaiEffect:new(effectData.ShangHai));
		elseif effectsData.ZhuoShao then
			table.insert(effects, ZhuoShaoEffect:new(effectData.ZhuoShao);
		end
	end
	return effects;
end

BulletBehavior = class("BulletBehavior", BaseBehavior);

function BulletBehavior:initialize(behaviorData)
	self.behaviorID = behaviorData.behaviorID;
	self.targets = behaviorData.targetIDs;
	BaseBehavior.initialize(self, behaviorData);
end

function BulletBehavior:Execute()
	--TODO 根据Bullet配置中的参数，得到飞行及特效参数
	
end

function BulletBehavior:OnHit()
	for i = 1, #self.exeEffects do
		self.exeEffects[i]:Execute();
	end
	for i = 1, #self.triEffects do
		self.triEffects[i]:Trigger();
	end
end




BaseEffect = class("BaseEffect");

function BaseEffect:Execute()
end

function BaseEffect:Trigger()
end

ShangHaiEffect = class("ShangHaiEffect", BaseEffect);

function ShangHaiEffect:initialize(damageData)
	--TODO 
	self.targetID = damageData.targetID;
	self.val = damageData.val;
end

function ShangHaiEffect:Execute()
	--TODO 掉血逻辑及表现
	
end

ZhuoShaoEffect = class("ZhuoShaoEffect", BaseEffect);

function ZhuoShaoEffect:initialize(bloodData)
	
end

function ZhuoShaoEffect:Execute()
	--TODO 添加灼烧效果表现
	
end

function ZhuoShaoEffect:Trigger()
	--TODO 掉血逻辑及表现
	
end