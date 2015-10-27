require "AutoGeneration/Protocol/share_ttypes.lua"
require "AutoGeneration/Protocol/login_ttypes.lua"
require "AutoGeneration/Protocol/user_ttypes.lua"
require "AutoGeneration/Protocol/hero_ttypes.lua"
require "AutoGeneration/Protocol/armor_ttypes.lua"
require "AutoGeneration/Protocol/weapon_ttypes.lua"
require "AutoGeneration/Protocol/magicCircle_ttypes.lua"
require "AutoGeneration/Protocol/fight_ttypes.lua"
require "AutoGeneration/Protocol/astrology_ttypes.lua"
require "AutoGeneration/Protocol/alchemy_ttypes.lua"
require "AutoGeneration/Protocol/forging_ttypes.lua"
require "AutoGeneration/Protocol/tools_ttypes.lua"
require "AutoGeneration/Protocol/trading_ttypes.lua"
require "AutoGeneration/Protocol/shop_ttypes.lua"
require "AutoGeneration/Protocol/VIP_ttypes.lua"
require "AutoGeneration/Protocol/dailyQuest_ttypes.lua"
require "AutoGeneration/Protocol/guild_ttypes.lua"

function _NewMsg(msgType)
	if msgType == 11945 then return C2SApprovalMember:new{};
	elseif msgType == 55917 then return UpdateConfigData:new{};
	elseif msgType == 59948 then return C2SPvp:new{};
	elseif msgType == 40053 then return C2SRequestGuildDetail:new{};
	elseif msgType == 36659 then return S2CHeroIncrQuality:new{};
	elseif msgType == 14374 then return C2SApplyInfo:new{};
	elseif msgType == 47163 then return S2CFightResult:new{};
	elseif msgType == 11932 then return S2CGetDailyStamina:new{};
	elseif msgType == 8035 then return C2SSellItem:new{};
	elseif msgType == 76966 then return C2SRequestGuildList:new{};
	elseif msgType == 51509 then return C2SPvpSettlemennt:new{};
	elseif msgType == 36195 then return S2CSearchGuild:new{};
	elseif msgType == 16994 then return C2SPersistShop:new{};
	elseif msgType == 48508 then return S2CGuildSign:new{};
	elseif msgType == 14844 then return C2SGuildSign:new{};
	elseif msgType == 72568 then return S2CQuitGuild:new{};
	elseif msgType == 35008 then return S2CLightAstrology:new{};
	elseif msgType == 95767 then return S2CGetDailyAction:new{};
	elseif msgType == 49620 then return S2CEquipSkillItem:new{};
	elseif msgType == 62007 then return C2SWeaponIncrQuality:new{};
	elseif msgType == 12174 then return C2SJoinInfo:new{};
	elseif msgType == 22805 then return C2SShopManualRefresh:new{};
	elseif msgType == 40419 then return Challenge:new{};
	elseif msgType == 76424 then return S2CGuildDissolution:new{};
	elseif msgType == 63187 then return S2CShopItem:new{};
	elseif msgType == 20856 then return C2SPurchasePvpCount:new{};
	elseif msgType == 78246 then return S2CGetInfo:new{};
	elseif msgType == 21718 then return LoginRepeatNotice:new{};
	elseif msgType == 66151 then return S2CErrorNotify:new{};
	elseif msgType == 26396 then return C2SPurchaseEliteFB:new{};
	elseif msgType == 4183 then return S2CForgingComposeOneKey:new{};
	elseif msgType == 39120 then return S2CPurchaseSkillPoint:new{};
	elseif msgType == 47141 then return C2SDiamondTrading:new{};
	elseif msgType == 1972 then return S2CShopAutoRefresh:new{};
	elseif msgType == 61032 then return S2CArmorIncrQuality:new{};
	elseif msgType == 31982 then return S2CEquipForging:new{};
	elseif msgType == 39452 then return S2CBattleHero:new{};
	elseif msgType == 75041 then return S2CSyncDailyTask:new{};
	elseif msgType == 66111 then return C2SPromoteToMaster:new{};
	elseif msgType == 55692 then return S2CPvp:new{};
	elseif msgType == 46219 then return ExceptionNotice:new{};
	elseif msgType == 23527 then return S2CApplyGuild:new{};
	elseif msgType == 50758 then return C2SFightLevel:new{};
	elseif msgType == 96453 then return S2CPvpSettlement:new{};
	elseif msgType == 13835 then return C2SGuildSeting:new{};
	elseif msgType == 68098 then return S2CPersistShop:new{};
	elseif msgType == 66589 then return C2SWeaponOneKeyIncrLvl:new{};
	elseif msgType == 88172 then return C2SModifyDeclaration:new{};
	elseif msgType == 95744 then return C2SLightAstrology:new{};
	elseif msgType == 56503 then return C2SGetDailyAction:new{};
	elseif msgType == 41638 then return S2CForgingCompose:new{};
	elseif msgType == 10356 then return C2SEquipSkillItem:new{};
	elseif msgType == 75831 then return S2CWeaponIncrQuality:new{};
	elseif msgType == 77289 then return S2CAlchemyCompose:new{};
	elseif msgType == 36629 then return S2CShopManualRefresh:new{};
	elseif msgType == 6472 then return C2SFightRaid:new{};
	elseif msgType == 43720 then return C2SGuildDissolution:new{};
	elseif msgType == 29843 then return C2SShopItem:new{};
	elseif msgType == 97786 then return BroadcastChannel:new{};
	elseif msgType == 98811 then return S2CGoldTrading:new{};
	elseif msgType == 21510 then return C2SPurchaseStamina:new{};
	elseif msgType == 67301 then return S2CKickOutGuild:new{};
	elseif msgType == 48358 then return L2SOffLineNotice:new{};
	elseif msgType == 64298 then return S2CAlchemyDecompose:new{};
	elseif msgType == 40158 then return S2CCharge:new{};
	elseif msgType == 28328 then return C2SArmorIncrQuality:new{};
	elseif msgType == 47758 then return C2SEquipForging:new{};
	elseif msgType == 95868 then return C2SBattleHero:new{};
	elseif msgType == 83622 then return C2SGetInfo:new{};
	elseif msgType == 90486 then return C2SGetIDTask:new{};
	elseif msgType == 17707 then return C2SCreateGuild:new{};
	elseif msgType == 68079 then return C2SJoinGuild:new{};
	elseif msgType == 83295 then return S2CPromoteToMaster:new{};
	elseif msgType == 50090 then return C2SWeaponIncrLevel:new{};
	elseif msgType == 359 then return S2CSkillIncrLevel:new{};
	elseif msgType == 68597 then return S2CRequestGuildDetail:new{};
	elseif msgType == 19603 then return S2CApprovalNotice:new{};
	elseif msgType == 79943 then return C2SApplyGuild:new{};
	elseif msgType == 45570 then return C2SComposeHero:new{};
	elseif msgType == 80761 then return S2CMagicCircleIncrLevel:new{};
	elseif msgType == 79466 then return KeepAlive:new{};
	elseif msgType == 38904 then return C2SQuitGuild:new{};
	elseif msgType == 64939 then return S2CGuildSeting:new{};
	elseif msgType == 76277 then return S2CArmorIncrLevel:new{};
	elseif msgType == 43580 then return S2CPurchaseEliteFB:new{};
	elseif msgType == 51453 then return S2CWeaponOneKeyIncrLvl:new{};
	elseif msgType == 1996 then return S2CModifyDeclaration:new{};
	elseif msgType == 36341 then return C2SPurchaseMoneyTree:new{};
	elseif msgType == 2374 then return C2SForgingCompose:new{};
	elseif msgType == 24338 then return S2CPurchaseMoneyTreeTen:new{};
	elseif msgType == 66016 then return S2CNewApplyInfo:new{};
	elseif msgType == 38025 then return C2SAlchemyCompose:new{};
	elseif msgType == 40136 then return S2CFightRaid:new{};
	elseif msgType == 35791 then return ClientChannelResponse:new{};
	elseif msgType == 35747 then return S2CLoadUserInfo:new{};
	elseif msgType == 29741 then return L2SConnectNotice:new{};
	elseif msgType == 28750 then return S2CCreateSummoner:new{};
	elseif msgType == 38694 then return S2CPurchaseStamina:new{};
	elseif msgType == 79729 then return C2SLogin:new{};
	elseif msgType == 83077 then return C2SKickOutGuild:new{};
	elseif msgType == 10576 then return C2SPurchaseSkillPoint:new{};
	elseif msgType == 31594 then return C2SAlchemyDecompose:new{};
	elseif msgType == 37080 then return S2CNewJoinInfo:new{};
	elseif msgType == 30654 then return C2SCharge:new{};
	elseif msgType == 38191 then return S2CNewTask:new{};
	elseif msgType == 96251 then return S2CBuyMagicCircle:new{};
	elseif msgType == 83350 then return S2CArmorOneKeyIncrLvl:new{};
	elseif msgType == 55511 then return L2SDisConnectNotice:new{};
	elseif msgType == 24150 then return S2CGetIDTask:new{};
	elseif msgType == 19475 then return C2SHeroIncrQuality:new{};
	elseif msgType == 68811 then return S2CCreateGuild:new{};
	elseif msgType == 1743 then return S2CJoinGuild:new{};
	elseif msgType == 48038 then return S2CApplyInfo:new{};
	elseif msgType == 51209 then return S2CApprovalMember:new{};
	elseif msgType == 67274 then return S2CWeaponIncrLevel:new{};
	elseif msgType == 61095 then return C2SSkillIncrLevel:new{};
	elseif msgType == 23828 then return C2SModifyAffiche:new{};
	elseif msgType == 52357 then return ClientChannelRequest:new{};
	elseif msgType == 96674 then return S2CComposeHero:new{};
	elseif msgType == 96059 then return C2SFightResult:new{};
	elseif msgType == 49977 then return C2SMagicCircleIncrLevel:new{};
	elseif msgType == 41379 then return S2CSellItem:new{};
	elseif msgType == 9670 then return S2CRequestGuildList:new{};
	elseif msgType == 33976 then return LinkChannelRequest:new{};
	elseif msgType == 350 then return BatchDisConnectNotice:new{};
	elseif msgType == 37013 then return C2SArmorIncrLevel:new{};
	elseif msgType == 94748 then return C2SGetDailyStamina:new{};
	elseif msgType == 50165 then return S2CPurchaseMoneyTree:new{};
	elseif msgType == 93554 then return C2SPurchaseMoneyTreeTen:new{};
	elseif msgType == 45518 then return S2CJoinInfo:new{};
	elseif msgType == 75062 then return GSChannelResponse:new{};
	elseif msgType == 34772 then return S2CModifyAffiche:new{};
	elseif msgType == 53560 then return S2CPurchasePvpCount:new{};
	elseif msgType == 51523 then return C2SLoadUserInfo:new{};
	elseif msgType == 89486 then return C2SCreateSummoner:new{};
	elseif msgType == 89713 then return S2CLogin:new{};
	elseif msgType == 92073 then return C2SSystemInfo:new{};
	elseif msgType == 85091 then return C2SSearchGuild:new{};
	elseif msgType == 36014 then return KeepLinkAlive:new{};
	elseif msgType == 40744 then return S2CKickOutNotice:new{};
	elseif msgType == 86405 then return S2CDiamondTrading:new{};
	elseif msgType == 84788 then return C2SShopAutoRefresh:new{};
	elseif msgType == 94342 then return S2CFightLevel:new{};
	elseif msgType == 56987 then return C2SBuyMagicCircle:new{};
	elseif msgType == 54806 then return C2SArmorOneKeyIncrLvl:new{};
	elseif msgType == 66755 then return C2SFogingComposeOneKey:new{};
	elseif msgType == 47707 then return C2SGoldTrading:new{};
	end

end
function C2SApprovalMember:GetType()
	return 11945;
end

function UpdateConfigData:GetType()
	return 55917;
end

function C2SPvp:GetType()
	return 59948;
end

function C2SRequestGuildDetail:GetType()
	return 40053;
end

function S2CHeroIncrQuality:GetType()
	return 36659;
end

function C2SApplyInfo:GetType()
	return 14374;
end

function S2CFightResult:GetType()
	return 47163;
end

function S2CGetDailyStamina:GetType()
	return 11932;
end

function C2SSellItem:GetType()
	return 8035;
end

function C2SRequestGuildList:GetType()
	return 76966;
end

function C2SPvpSettlemennt:GetType()
	return 51509;
end

function S2CSearchGuild:GetType()
	return 36195;
end

function C2SPersistShop:GetType()
	return 16994;
end

function S2CGuildSign:GetType()
	return 48508;
end

function C2SGuildSign:GetType()
	return 14844;
end

function S2CQuitGuild:GetType()
	return 72568;
end

function S2CLightAstrology:GetType()
	return 35008;
end

function S2CGetDailyAction:GetType()
	return 95767;
end

function S2CEquipSkillItem:GetType()
	return 49620;
end

function C2SWeaponIncrQuality:GetType()
	return 62007;
end

function C2SJoinInfo:GetType()
	return 12174;
end

function C2SShopManualRefresh:GetType()
	return 22805;
end

function Challenge:GetType()
	return 40419;
end

function S2CGuildDissolution:GetType()
	return 76424;
end

function S2CShopItem:GetType()
	return 63187;
end

function C2SPurchasePvpCount:GetType()
	return 20856;
end

function S2CGetInfo:GetType()
	return 78246;
end

function LoginRepeatNotice:GetType()
	return 21718;
end

function S2CErrorNotify:GetType()
	return 66151;
end

function C2SPurchaseEliteFB:GetType()
	return 26396;
end

function S2CForgingComposeOneKey:GetType()
	return 4183;
end

function S2CPurchaseSkillPoint:GetType()
	return 39120;
end

function C2SDiamondTrading:GetType()
	return 47141;
end

function S2CShopAutoRefresh:GetType()
	return 1972;
end

function S2CArmorIncrQuality:GetType()
	return 61032;
end

function S2CEquipForging:GetType()
	return 31982;
end

function S2CBattleHero:GetType()
	return 39452;
end

function S2CSyncDailyTask:GetType()
	return 75041;
end

function C2SPromoteToMaster:GetType()
	return 66111;
end

function S2CPvp:GetType()
	return 55692;
end

function ExceptionNotice:GetType()
	return 46219;
end

function S2CApplyGuild:GetType()
	return 23527;
end

function C2SFightLevel:GetType()
	return 50758;
end

function S2CPvpSettlement:GetType()
	return 96453;
end

function C2SGuildSeting:GetType()
	return 13835;
end

function S2CPersistShop:GetType()
	return 68098;
end

function C2SWeaponOneKeyIncrLvl:GetType()
	return 66589;
end

function C2SModifyDeclaration:GetType()
	return 88172;
end

function C2SLightAstrology:GetType()
	return 95744;
end

function C2SGetDailyAction:GetType()
	return 56503;
end

function S2CForgingCompose:GetType()
	return 41638;
end

function C2SEquipSkillItem:GetType()
	return 10356;
end

function S2CWeaponIncrQuality:GetType()
	return 75831;
end

function S2CAlchemyCompose:GetType()
	return 77289;
end

function S2CShopManualRefresh:GetType()
	return 36629;
end

function C2SFightRaid:GetType()
	return 6472;
end

function C2SGuildDissolution:GetType()
	return 43720;
end

function C2SShopItem:GetType()
	return 29843;
end

function BroadcastChannel:GetType()
	return 97786;
end

function S2CGoldTrading:GetType()
	return 98811;
end

function C2SPurchaseStamina:GetType()
	return 21510;
end

function S2CKickOutGuild:GetType()
	return 67301;
end

function L2SOffLineNotice:GetType()
	return 48358;
end

function S2CAlchemyDecompose:GetType()
	return 64298;
end

function S2CCharge:GetType()
	return 40158;
end

function C2SArmorIncrQuality:GetType()
	return 28328;
end

function C2SEquipForging:GetType()
	return 47758;
end

function C2SBattleHero:GetType()
	return 95868;
end

function C2SGetInfo:GetType()
	return 83622;
end

function C2SGetIDTask:GetType()
	return 90486;
end

function C2SCreateGuild:GetType()
	return 17707;
end

function C2SJoinGuild:GetType()
	return 68079;
end

function S2CPromoteToMaster:GetType()
	return 83295;
end

function C2SWeaponIncrLevel:GetType()
	return 50090;
end

function S2CSkillIncrLevel:GetType()
	return 359;
end

function S2CRequestGuildDetail:GetType()
	return 68597;
end

function S2CApprovalNotice:GetType()
	return 19603;
end

function C2SApplyGuild:GetType()
	return 79943;
end

function C2SComposeHero:GetType()
	return 45570;
end

function S2CMagicCircleIncrLevel:GetType()
	return 80761;
end

function KeepAlive:GetType()
	return 79466;
end

function C2SQuitGuild:GetType()
	return 38904;
end

function S2CGuildSeting:GetType()
	return 64939;
end

function S2CArmorIncrLevel:GetType()
	return 76277;
end

function S2CPurchaseEliteFB:GetType()
	return 43580;
end

function S2CWeaponOneKeyIncrLvl:GetType()
	return 51453;
end

function S2CModifyDeclaration:GetType()
	return 1996;
end

function C2SPurchaseMoneyTree:GetType()
	return 36341;
end

function C2SForgingCompose:GetType()
	return 2374;
end

function S2CPurchaseMoneyTreeTen:GetType()
	return 24338;
end

function S2CNewApplyInfo:GetType()
	return 66016;
end

function C2SAlchemyCompose:GetType()
	return 38025;
end

function S2CFightRaid:GetType()
	return 40136;
end

function ClientChannelResponse:GetType()
	return 35791;
end

function S2CLoadUserInfo:GetType()
	return 35747;
end

function L2SConnectNotice:GetType()
	return 29741;
end

function S2CCreateSummoner:GetType()
	return 28750;
end

function S2CPurchaseStamina:GetType()
	return 38694;
end

function C2SLogin:GetType()
	return 79729;
end

function C2SKickOutGuild:GetType()
	return 83077;
end

function C2SPurchaseSkillPoint:GetType()
	return 10576;
end

function C2SAlchemyDecompose:GetType()
	return 31594;
end

function S2CNewJoinInfo:GetType()
	return 37080;
end

function C2SCharge:GetType()
	return 30654;
end

function S2CNewTask:GetType()
	return 38191;
end

function S2CBuyMagicCircle:GetType()
	return 96251;
end

function S2CArmorOneKeyIncrLvl:GetType()
	return 83350;
end

function L2SDisConnectNotice:GetType()
	return 55511;
end

function S2CGetIDTask:GetType()
	return 24150;
end

function C2SHeroIncrQuality:GetType()
	return 19475;
end

function S2CCreateGuild:GetType()
	return 68811;
end

function S2CJoinGuild:GetType()
	return 1743;
end

function S2CApplyInfo:GetType()
	return 48038;
end

function S2CApprovalMember:GetType()
	return 51209;
end

function S2CWeaponIncrLevel:GetType()
	return 67274;
end

function C2SSkillIncrLevel:GetType()
	return 61095;
end

function C2SModifyAffiche:GetType()
	return 23828;
end

function ClientChannelRequest:GetType()
	return 52357;
end

function S2CComposeHero:GetType()
	return 96674;
end

function C2SFightResult:GetType()
	return 96059;
end

function C2SMagicCircleIncrLevel:GetType()
	return 49977;
end

function S2CSellItem:GetType()
	return 41379;
end

function S2CRequestGuildList:GetType()
	return 9670;
end

function LinkChannelRequest:GetType()
	return 33976;
end

function BatchDisConnectNotice:GetType()
	return 350;
end

function C2SArmorIncrLevel:GetType()
	return 37013;
end

function C2SGetDailyStamina:GetType()
	return 94748;
end

function S2CPurchaseMoneyTree:GetType()
	return 50165;
end

function C2SPurchaseMoneyTreeTen:GetType()
	return 93554;
end

function S2CJoinInfo:GetType()
	return 45518;
end

function GSChannelResponse:GetType()
	return 75062;
end

function S2CModifyAffiche:GetType()
	return 34772;
end

function S2CPurchasePvpCount:GetType()
	return 53560;
end

function C2SLoadUserInfo:GetType()
	return 51523;
end

function C2SCreateSummoner:GetType()
	return 89486;
end

function S2CLogin:GetType()
	return 89713;
end

function C2SSystemInfo:GetType()
	return 92073;
end

function C2SSearchGuild:GetType()
	return 85091;
end

function KeepLinkAlive:GetType()
	return 36014;
end

function S2CKickOutNotice:GetType()
	return 40744;
end

function S2CDiamondTrading:GetType()
	return 86405;
end

function C2SShopAutoRefresh:GetType()
	return 84788;
end

function S2CFightLevel:GetType()
	return 94342;
end

function C2SBuyMagicCircle:GetType()
	return 56987;
end

function C2SArmorOneKeyIncrLvl:GetType()
	return 54806;
end

function C2SFogingComposeOneKey:GetType()
	return 66755;
end

function C2SGoldTrading:GetType()
	return 47707;
end

