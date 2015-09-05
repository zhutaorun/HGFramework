--用闭包方式封装UIEventListener接口
LuaUIEventListener = {};

--注册点击事件
--gameObj: 需要注册点击事件的游戏对象，GameObject
--self: 回调对象，table
--callback: 回调函数, function
--回调参数：点击GameObject
function LuaUIEventListener.AddOnClick(gameObj, self, callback)
	if not LuaUIEventListener.CheckCallbackNULL(gameObj, self, callback) then
        return;
    end
	UIEventListener.Get(gameObj).onClick = function ()
		callback(self, gameObj);
	end
end

--注册进度值改变事件
--progressBar: 需要注册进度值改变的UIProgressBar对象，UIProgressBar
--self: 回调对象，table
--callback: 回调函数，function
--回调参数：当前值
function LuaUIEventListener.AddOnValueChange(progressBar, self, callback)
	if not progressBar then
		Logger.Error("AddOnValueChange progressBar is nil");
		return;
	end
	if not self then
		Logger.Error("AddOnValueChange progressBar is nil");
		return;
	end
	if not callback then
		Logger.Error("AddOnValueChange callback is nil");
		return;
	end
	EventDelegate.Set(progressBar.onChange, function ()
		callback(self, progressBar.value);
	end)
end

--popuplist的value改变事件
--UIPopuplist: 需要注册popuplist值改变的UIPopuplist对象，UIPopuplist
--self: 回调对象，table
--callback: 回调函数，function
--回调参数：当前值
function LuaUIEventListener.AddOnPopValueChange(popuplist, self, callback)
	if not popuplist then
		Logger.Error("AddOnPopValueChange popuplist is nil");
		return;
	end
	if not self then
		Logger.Error("AddOnPopValueChange popuplist is nil");
		return;
	end
	if not callback then
		Logger.Error("AddOnPopValueChange callback is nil");
		return;
	end
	EventDelegate.Set(popuplist.onChange, function ()
		callback(self, popuplist.value);
	end)
end

--注册拖拽事件
--gameObj: 要注册拖拽的游戏对象
--self: 为了OOP的table对象
--callback: 回调函数
function LuaUIEventListener.AddOnDrag(gameObj, self, callback)
    --TODO 检查参数合法性
    if not LuaUIEventListener.CheckCallbackNULL(gameObj, self, callback) then
        return;
    end
    UIEventListener.Get(gameObj).onDrag = function(go, delta)
        callback(self, go, delta);
    end
end

function LuaUIEventListener.CheckCallbackNULL(gameObj, self, callback)
    if not gameObj then
		Logger.Error("AddOnClick gameobject is nil");
		return false;
	end
	if not self then
		Logger.Error("AddOnClick self is nil");
		return false;
	end
	if not callback then
		Logger.Error("AddOnClick callback is nil");
		return false;
	end
    return true;
end