import "UnityEngine"

--全局头文件
class = require "Lib/middleclass.lua"
json = require "cjson" 
require "Framework/Utility.lua"
require "Framework/LuaUIEventListener.lua"
require "Framework/MsgDispatcher.lua"
require "Framework/LuaResMgr.lua"
require "Framework/LuaSceneMgr.lua"
require "Thrift/TMemoryBuffer.lua"
require "Thrift/TBinaryProtocol.lua"
require "Config/config_ttypes.lua"
require "Config/Config.lua"

require "Demo/SelectHero/SelectHeroSceneLoading.lua"

data = {};

function main()
	--测试cjson
	local json_text = '{"username":"hello","password":"world"}';
	local value = json.decode(json_text);
	print("Json Object : " .. value["username"] .. " : " .. value["password"]);
	local str= json.encode(value);
	print("Json String : " .. str);

	--测试thrift格式的配置表
	Config.Load();

	--测试demo
	local selectHeroLoading = Utility.CreateLuaBehaviour(GameObject("SelectHeroSceneLoading"), SelectHeroSceneLoading:new());
end