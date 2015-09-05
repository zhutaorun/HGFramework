Config = {};

function Config.Load()
	Config.HeroInfoConfig = Config.LoadConfig("HeroInfoConfig.bytes", HeroInfoConfigMap:new{});

end

function Config.GetHeroInfoConfig(id)
	return Config.HeroInfoConfig[id];
end



function Config.LoadConfig(dataPath, configMap)
    local buffer = ConfigMgr.Instance():GetConfig(dataPath);
	local transport = TMemoryBuffer:new{};
	transport:resetBuffer(buffer);
	local protocol = TBinaryProtocol:new{ trans = transport };
	configMap:read(protocol);
    return configMap.configMap;
end