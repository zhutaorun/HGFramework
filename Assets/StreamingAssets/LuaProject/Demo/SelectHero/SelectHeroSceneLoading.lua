--region *.lua
--Date
--此文件由[BabeLua]插件自动生成
require "Demo/SelectHero/SelectHeroScene.lua"
require "Demo/SelectHero/SelectHeroUI.lua"

local GameObject = UnityEngine.GameObject;
local Vector3 = UnityEngine.Vector3;

--选择英雄场景加载器
SelectHeroSceneLoading = class("SelectHeroSceneLoading");

function SelectHeroSceneLoading:Awake()
	local logicRes = { "Model/Hero/knight.prefab", "Model/Hero/magician.prefab", "Model/Hero/priest.prefab" };
	SceneMgrWrapper.EnterScene("loading.scene", self, self.OnLoadingDone, 
		"select_hero.scene", logicRes, self, self.OnSceneLoadDone, self.OnSceneLoadUpdate);
end

--Loading场景加载完成
function SelectHeroSceneLoading:OnLoadingDone()
	local loadingUI = _CreateLuaBehaviour(GameObject.Find("LoadingUI"), LoadingUI:new());
	loadingUI:Show();
end

--游戏场景加载完成
function SelectHeroSceneLoading:OnSceneLoadDone(sceneName)
	--英雄们
	local knight = GameObject.Instantiate(SceneMgrWrapper.GetResObj("Model/Hero/knight.prefab"));
	knight.name = "knight";
	knight.transform.position = Vector3(0, 0, 0);
	local magician = GameObject.Instantiate(SceneMgrWrapper.GetResObj("Model/Hero/magician.prefab"));
	magician.name = "magician";
	magician.transform.position = Vector3(4, 0, 0);
	local priest = GameObject.Instantiate(SceneMgrWrapper.GetResObj("Model/Hero/priest.prefab"));
	priest.name = "priest";
	priest.transform.position = Vector3(-4, 0, 0);
	--新场景逻辑
	_SendLogicMsg("SceneLoadDone");
	_CreateLuaBehaviour(GameObject.Find("Scene"), SelectHeroScene:new());
	_CreateLuaBehaviour(GameObject.Find("UI"), SelectHeroUI:new());
end

function SelectHeroSceneLoading:OnSceneLoadUpdate(sceneName, progress)
	print(sceneName .. " " .. progress);
end

--endregion
