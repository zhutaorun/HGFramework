--用闭包方式封装ResMgr
LuaResMgr = class("LuaResMgr");

LuaResMgr.HeroModelFormat = "Model/Hero/%s.prefab";

function LuaResMgr.LoadScene(sceneName, self, callback)
	ResMgr.Instance():LoadScene(sceneName, function (scene, resObj)
		callback(self, scene, nil);
	end, nil);
end

function LuaResMgr.LoadRes(resName, self, callback)
	ResMgr.Instance():LoadRes(resName, function (res, resObj)
		callback(self, res, resObj);
	end);
end

function LuaResMgr.GetHeroModelPath(name)
    return string.format(LuaResMgr.HeroModelFormat, name);
end