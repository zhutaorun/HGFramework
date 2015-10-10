--region *.lua
--Date
--此文件由[BabeLua]插件自动生成
local Input = UnityEngine.Input;
local Physics = UnityEngine.Physics;

PCCtrl = class("PCCtrl");

function PCCtrl:initialize(camera, hero)
    self.camera = camera;
    self.hero = hero;
end

function PCCtrl:Update()
    --操作
    --使用鼠标右键移动
    if Input.GetMouseButtonDown(1) then
        self.moving = true;
    end
    if Input.GetMouseButtonUp(1) then
        self.moving = false;
    end
    if self.moving then
        --检测碰撞
        local ray = self.camera:ScreenPointToRay(Input.mousePosition);
        local ret, hitInfo = Physics.Raycast(ray, SLua.out);
        if ret and hitInfo.collider.name == "Terrain" then
            self.hero:HandleMsg("MOVE_MSG", hitInfo.point);
        end
    end
    --滚轮拉伸镜头
    if Input.GetAxis("Mouse ScrollWheel") > 0 or Input.GetAxis("Mouse ScrollWheel") < 0 then
        local offset = Input.GetAxis("Mouse ScrollWheel") * 5;
        
    end
    --使用鼠标左键键攻击
    if Input.GetMouseButtonUp(0) then
        self.hero:HandleMsg("ATTACK_MSG");
    end
    --同步英雄和摄像机位置
--    if self.hero:IsMoving() then
--        self.camera.transform.position = self.hero.trans.position + self.delta; 
--    end
end

--endregion
