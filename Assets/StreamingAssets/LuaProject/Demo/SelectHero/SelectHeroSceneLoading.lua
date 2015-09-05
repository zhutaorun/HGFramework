--region *.lua
--Date
--此文件由[BabeLua]插件自动生成
require "Demo/Loading.lua"
require "Demo/SelectHero/SelectHeroScene.lua"
require "Demo/SelectHero/SelectHeroUI.lua"

--选择英雄场景加载器
SelectHeroSceneLoading = class("SelectHeroSceneLoading");

function SelectHeroSceneLoading:Awake()
	local logicRes = { "Model/Hero/knight.prefab", "Model/Hero/magician.prefab", "Model/Hero/priest.prefab" };
	LuaSceneMgr.EnterScene("loading.scene", self, self.OnLoadingDone, 
		"select_hero.scene", logicRes, self, self.OnSceneLoadDone, self.OnSceneLoadUpdate);
end

--Loading场景加载完成
function SelectHeroSceneLoading:OnLoadingDone()
	local loading = Utility.CreateLuaBehaviour(GameObject.Find("Loading"), Loading:new());
	loading:Show();
end

--游戏场景加载完成
function SelectHeroSceneLoading:OnSceneLoadDone(sceneName)
	--英雄们
	local knight = GameObject.Instantiate(LuaSceneMgr.GetResObj("Model/Hero/knight.prefab"));
	knight.name = "knight";
	knight.transform.position = Vector3(0, 0, 0);
	local magician = GameObject.Instantiate(LuaSceneMgr.GetResObj("Model/Hero/magician.prefab"));
	magician.name = "magician";
	magician.transform.position = Vector3(4, 0, 0);
	local priest = GameObject.Instantiate(LuaSceneMgr.GetResObj("Model/Hero/priest.prefab"));
	priest.name = "priest";
	priest.transform.position = Vector3(-4, 0, 0);
	--新场景逻辑
	MsgDispatcher.SendLogicMsg("SceneLoadDone");
	Utility.CreateLuaBehaviour(GameObject.Find("Scene"), SelectHeroScene:new());
	Utility.CreateLuaBehaviour(GameObject.Find("UI"), SelectHeroUI:new());
end

function SelectHeroSceneLoading:OnSceneLoadUpdate(sceneName, progress)
	print(sceneName .. " " .. progress);
end

--endregion
