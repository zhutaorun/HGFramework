SceneMgrWrapper = {};

function SceneMgrWrapper.EnterScene(loadingSceneName, self1, loadingDoneCallback, sceneName, logicResNames, self2, loadDoneCallback, loadUpdateCallback)
	SceneMgr.Instance():EnterScene(loadingSceneName, 
	function (loadingSceneName)
		if loadingDoneCallback then
			loadingDoneCallback(self1, loadingSceneName);
		end
	end,
	sceneName, logicResNames, 
	function (sceneName)
		if loadDoneCallback then
			loadDoneCallback(self2, sceneName);
		end
	end,
	function (sceneName, progress)
		if loadUpdateCallback then
			loadUpdateCallback(self2, sceneName, progress);
		end
	end);
end

function SceneMgrWrapper.GetResObj(resName)
	return SceneMgr.Instance():GetResObj(resName);
end