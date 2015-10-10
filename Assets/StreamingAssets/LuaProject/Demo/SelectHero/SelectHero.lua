local Vector3 = UnityEngine.Vector3;
local Quaternion = UnityEngine.Quaternion;

--选择英雄场景下的英雄脚本
SelectHero = class("SelectHero");

function SelectHero:Awake()
	self.anim = self.gameObj:GetComponent("Animation");
	UIEventListenerWrapper.AddOnClick(self.gameObj, self, self.OnClick);
end 

function SelectHero:OnClick()
	local arg = {};
	arg["id"] = self.id;
	_SendLogicMsg("SelectHero", arg);
end

function SelectHero:Select()
	--突出显示
	self.trans:Rotate(Vector3.up, 180);
	self.trans.localScale = Vector3(1.5, 1.5, 1.5);
	self.anim:Play("attack1");
	self.anim:PlayQueued("idle");
end

function SelectHero:UnSelect()
	--正常显示
	self.trans.localScale = Vector3.one;
	self.trans.localRotation = Quaternion.identity;
end