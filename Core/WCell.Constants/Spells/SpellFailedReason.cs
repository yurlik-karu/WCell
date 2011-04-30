
///
/// This file was automatically created, using WCell's CodeFileWriter
/// Date: 30/04/2011
///

namespace WCell.Constants.Spells
{
	public enum SpellFailedReason : byte 
	{
		Success = 0,
		AffectingCombat = 1,
		AlreadyAtFullHealth = 2,
		AlreadyAtFullMana = 3,
		AlreadyAtFullPower = 4,
		AlreadyBeingTamed = 5,
		AlreadyHaveCharm = 6,
		AlreadyHaveSummon = 7,
		AlreadyHavePet = 8,
		AlreadyOpen = 9,
		AuraBounced = 10,
		AutotrackInterrupted = 11,
		BadImplicitTargets = 12,
		BadTargets = 13,
		CantBeCharmed = 14,
		CantBeDisenchanted = 15,
		CantBeDisenchantedSkill = 16,
		CantBeMilled = 17,
		CantBeProspected = 18,
		CantCastOnTapped = 19,
		CantDuelWhileInvisible = 20,
		CantDuelWhileStealthed = 21,
		CantStealth = 22,
		CasterAurastate = 23,
		CasterDead = 24,
		Charmed = 25,
		ChestInUse = 26,
		Confused = 27,
		DontReport = 28,
		EquippedItem = 29,
		EquippedItemClass = 30,
		EquippedItemClassMainhand = 31,
		EquippedItemClassOffhand = 32,
		Error = 33,
		Falling = 34,
		Fizzle = 35,
		Fleeing = 36,
		FoodLowlevel = 37,
		Highlevel = 38,
		HungerSatiated = 39,
		Immune = 40,
		IncorrectArea = 41,
		Interrupted = 42,
		InterruptedCombat = 43,
		ItemAlreadyEnchanted = 44,
		ItemGone = 45,
		ItemNotFound = 46,
		ItemNotReady = 47,
		LevelRequirement = 48,
		LineOfSight = 49,
		Lowlevel = 50,
		LowCastlevel = 51,
		MainhandEmpty = 52,
		Moving = 53,
		NeedAmmo = 54,
		NeedAmmoPouch = 55,
		NeedExoticAmmo = 56,
		NeedMoreItems = 57,
		Nopath = 58,
		NotBehind = 59,
		NotFishable = 60,
		NotFlying = 61,
		NotHere = 62,
		NotInfront = 63,
		NotInControl = 64,
		NotKnown = 65,
		NotMounted = 66,
		NotOnTaxi = 67,
		NotOnTransport = 68,
		NotReady = 69,
		NotShapeshift = 70,
		NotStanding = 71,
		NotTradeable = 72,
		NotTrading = 73,
		NotUnsheathed = 74,
		NotWhileGhost = 75,
		NoChargesRemain = 76,
		NotWhileLooting = 77,
		NoAmmo = 78,
		NoChampion = 79,
		NoComboPoints = 80,
		NoDueling = 81,
		NoEndurance = 82,
		NoFish = 83,
		NoItemsWhileShapeshifted = 84,
		NoMountsAllowed = 85,
		NoPet = 86,
		NoPower = 87,
		NothingToDispel = 88,
		NothingToSteal = 89,
		OnlyAbovewater = 90,
		OnlyDaytime = 91,
		OnlyIndoors = 92,
		OnlyMounted = 93,
		OnlyNighttime = 94,
		OnlyOutdoors = 95,
		OnlyShapeshift = 96,
		OnlyStealthed = 97,
		OnlyUnderwater = 98,
		OutOfRange = 99,
		Pacified = 100,
		Possessed = 101,
		Reagents = 102,
		RequiresArea = 103,
		RequiresSpellFocus = 104,
		Rooted = 105,
		Silenced = 106,
		SpellInProgress = 107,
		SpellLearned = 108,
		SpellUnavailable = 109,
		Stunned = 110,
		TargetsDead = 111,
		TargetAffectingCombat = 112,
		TargetAurastate = 113,
		TargetDueling = 114,
		TargetEnemy = 115,
		TargetEnraged = 116,
		TargetFriendly = 117,
		TargetInCombat = 118,
		TargetIsPlayer = 119,
		TargetIsPlayerControlled = 120,
		TargetNotDead = 121,
		TargetNotInParty = 122,
		TargetNotLooted = 123,
		TargetNotPlayer = 124,
		TargetNoPockets = 125,
		TargetNoWeapons = 126,
		TargetNoRangedWeapons = 127,
		TargetUnskinnable = 128,
		ThirstSatiated = 129,
		TooClose = 130,
		TooManyOfItem = 131,
		TotemCategory = 132,
		Totems = 133,
		TryAgain = 134,
		UnitNotBehind = 135,
		UnitNotInfront = 136,
		VisionObscured = 137,
		WrongPetFood = 138,
		NotWhileFatigued = 139,
		TargetNotInInstance = 140,
		NotWhileTrading = 141,
		TargetNotInRaid = 142,
		TargetFreeforall = 143,
		NoEdibleCorpses = 144,
		OnlyBattlegrounds = 145,
		TargetNotGhost = 146,
		TransformUnusable = 147,
		WrongWeather = 148,
		DamageImmune = 149,
		PreventedByMechanic = 150,
		PlayTime = 151,
		Reputation = 152,
		MinSkill = 153,
		NotInRatedBattleground = 154,
		NotOnShapeshift = 155,
		NotOnStealthed = 156,
		NotOnDamageImmune = 157,
		NotOnMounted = 158,
		TooShallow = 159,
		TargetNotInSanctuary = 160,
		TargetIsTrivial = 161,
		BmOrInvisgod = 162,
		ExpertRidingRequirement = 163,
		ArtisanRidingRequirement = 164,
		NotIdle = 165,
		NotInactive = 166,
		PartialPlaytime = 167,
		NoPlaytime = 168,
		NotInBattleground = 169,
		NotInRaidInstance = 170,
		OnlyInArena = 171,
		TargetLockedToRaidInstance = 172,
		OnUseEnchant = 173,
		CantDoThatRightNow = 173,
		NotOnGround = 175,
		CustomError = 176,
		TooManySockets = 177,
		InvalidGlyph = 178,
		UniqueGlyph = 179,
		GlyphSocketLocked = 180,
		NoValidTargets = 181,
		ItemAtMaxCharges = 182,
		NotInBarbershop = 183,
		FishingTooLow = 184,
		ItemEnchantTradeWindow = 185,
		SummonPending = 186,
		MaxSockets = 187,
		PetCanRename = 188,
		TargetCannotBeResurrected = 189,
		NoActions = 190,
		CurrencyWeightMismatch = 191,
		WeightNotEnough = 192,
		WeightTooMuch = 193,
		NoVacantSeat = 194,
		NoLiquid = 195,
		OnlyNotSwimming = 196,
		ByNotMoving = 197,
		InCombatResLimitReached = 198,
		NotInArena = 199,
		TargetNotGrounded = 200,
		Unknown = 201,
		Ok = 0xFF
	}

}

