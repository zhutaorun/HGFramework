--region *.lua
--Date
--此文件由[BabeLua]插件自动生成

LoginUI = class("LoginUI");

function LoginUI:Awake()
    self.usernameInput = self.trans:Find("UsernameInput"):GetComponent("UIInput");
    UIEventListenerWrapper.AddOnClick(self.trans:Find("LoginButton").gameObject, self, LoginUI.OnLoginButtonClick);
end

function LoginUI:OnLoginButtonClick(args)
    if (self.usernameInput.value) then
        LoginService.Login(self.usernameInput.value);
    end
end

--endregion
