--加载场景
LoadingUI = class("LoadingUI")

function LoadingUI:Awake()
	self.tipsLabel = self.trans:Find("TipsLabel"):GetComponent("UILabel");
	self.loadingProgressBar = self.trans:Find("LoadingProgressBar"):GetComponent("UISlider");
	--注册加载完成消息
	_RegLogicMsg("SceneLoadDone", self, self.OnLoadDone);
end

function LoadingUI:Show()
	self.loadingProgressBar.value = 0;
end

function LoadingUI:Update()
	self.loadingProgressBar.value = self.loadingProgressBar.value + 0.05;
end

function LoadingUI:OnLoadDone()
	self.loadingProgressBar.value = 1;
	_UnRegLogicMsg("SceneLoadDone", self, self.OnLoadDone);
	self.gameObj:SetActive(false);
end