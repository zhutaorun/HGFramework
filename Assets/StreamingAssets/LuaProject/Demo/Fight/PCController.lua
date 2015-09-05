--region *.lua
--Date
--此文件由[BabeLua]插件自动生成

PCController = class("PCController")

function PCController:Init(camera, hero)
    self.camera = camera;
    self.hero = hero;
    self.delta = self.camera.transform.position - self.hero.trans.position;
end

function PCController:Update()
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
            self.hero:Translate("Move", hitInfo.point);
        end
    end
    --滚轮拉伸镜头
    if Input.GetAxis("Mouse ScrollWheel") > 0 or Input.GetAxis("Mouse ScrollWheel") < 0 then
        local offset = Input.GetAxis("Mouse ScrollWheel") * 5;
        self.camera.transform.position = self.camera.transform.position + self.camera.transform.forward * offset;
        self.delta = self.camera.transform.position - self.hero.trans.position;
    end
    --使用鼠标左键键攻击
    if Input.GetMouseButtonUp(0) then
        self.hero:Translate("Attack");
    end
    --同步英雄和摄像机位置
    if self.hero:IsMoving() then
        self.camera.transform.position = self.hero.trans.position + self.delta; 
    end
end

--endregion
