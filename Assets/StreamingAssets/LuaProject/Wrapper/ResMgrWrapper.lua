--用闭包方式封装ResMgr
ResMgrWrapper = class("ResMgrWrapper");

ResMgrWrapper.HeroModelFormat = "Model/Hero/%s.prefab";

function ResMgrWrapper.LoadScene(sceneName, self, callback)
	ResMgr.Instance():LoadScene(sceneName, function (scene, resObj)
		callback(self, scene, nil);
	end, nil);
end

function ResMgrWrapper.LoadRes(resName, self, callback)
	ResMgr.Instance():LoadRes(resName, function (res, resObj)
		callback(self, res, resObj);
	end);
end

function ResMgrWrapper.GetHeroModelPath(name)
    return string.format(ResMgrWrapper.HeroModelFormat, name);
end