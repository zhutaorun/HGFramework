require "Demo/SelectHero/SelectHero.lua"

local GameObject = UnityEngine.GameObject;
local Vector3 = UnityEngine.Vector3;

--选择英雄场景
SelectHeroScene = class("SelectHeroScene");

function SelectHeroScene:Awake()
	--灯光
	self.spotLightGO = GameObject.Find("Spotlight");
	self.spotLightGO:SetActive(false);
	--英雄
	self.heros = {};
	self.heros[1] = _CreateLuaBehaviour(GameObject.Find("knight"), SelectHero:new());
	self.heros[1].id = "1";
	self.heros[2] = _CreateLuaBehaviour(GameObject.Find("magician"), SelectHero:new());
	self.heros[2].id = "2";
	self.heros[3] = _CreateLuaBehaviour(GameObject.Find("priest"), SelectHero:new());
	self.heros[3].id = "3";
	--注册事件
	_RegLogicMsg("SelectHero", self, self.HandleSelectHeroMsg);
end

function SelectHeroScene:HandleSelectHeroMsg(arg)
    --保存选中英雄数据
    data.selectHeroID = arg["id"];
	for i = 1, #self.heros do
		local hero = self.heros[i];
		if arg["id"] == hero.id then
			hero:Select();
			--设置灯光
			if not self.spotLightGO.activeSelf then
				self.spotLightGO:SetActive(true);
			end
			self.spotLightGO.transform.position = Vector3(hero.trans.position.x, 10, 0);
		else
			hero:UnSelect();
		end
	end
end
