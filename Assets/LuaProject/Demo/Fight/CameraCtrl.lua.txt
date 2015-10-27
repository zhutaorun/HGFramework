--region *.lua
--Date
--此文件由[BabeLua]插件自动生成

CameraCtrl = class("CameraCtrl");

function CameraCtrl:initialize(camera, target)
    self.mCamera = camera;
    self.mTarget = target;
    self.mDelta = self.mCamera.transform.position - self.mTarget.position;
end

function CameraCtrl:Zoom(offset)
    self.mCamera.transform.position = self.mCamera.transform.position + self.mCamera.transform.forward * offset;
    self.mDelta = self.mCamera.transform.position - self.mTarget.position;
end

function CameraCtrl:Update()
    if self.mTarget.hasChanged then
        self.mCamera.transform.position = self.mTarget.position + self.mDelta; 
        self.mTarget.hasChanged = false;
    end
end


--endregion
