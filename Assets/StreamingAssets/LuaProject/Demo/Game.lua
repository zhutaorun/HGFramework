--全局头文件
class = require "Lib/MiddleClass/middleclass.lua"
json = require "cjson"
require "Lib/Thrift/TMemoryBuffer.lua"
require "Lib/Thrift/TBinaryProtocol.lua"
require "Framework/Utility.lua"
require "Framework/MsgDispatcher.lua"
require "Framework/ThriftNetMsgMgr.lua"
require "Wrapper/UIEventListenerWrapper.lua"
require "Wrapper/ResMgrWrapper.lua"
require "Wrapper/SceneMgrWrapper.lua"
require "AutoGeneration/Config/Config.lua"

require "Service/LoginService.lua"

require "Demo/LoadingUI.lua"
require "Demo/Login/LoginSceneLoading.lua"
require "Demo/SelectHero/SelectHeroSceneLoading.lua"

data = {};

local GameObject = UnityEngine.GameObject;

function main()
	--测试cjson
	local json_text = '{"username":"hello","password":"world"}';
	local value = json.decode(json_text);
	print("Json Object : " .. value["username"] .. " : " .. value["password"]);
	local str= json.encode(value);
	print("Json String : " .. str);

	--测试thrift格式的配置表
	Config.Load();

    _CreateLuaBehaviour(GameObject("SelectHeroSceneLoading"), SelectHeroSceneLoading:new(), "select_hero.scene", "aaa");


    --网络消息注册
--    LoginService.Init();
	--测试网络demo
--    _CreateLuaBehaviour(GameObject("LoginSceneLoading"), LoginSceneLoading:new(), "login.scene", "aaa");
--    NetMgr.Instance():Connect("127.0.0.1", 8083);
end