#if DISABLE_TEMP_FILE
// Wrapped in an if / end if so it doesnt compile
// public float { get; protected set; }

///--Offensive
///-Attacks
public float AttackSkillLevel { get; protected set; }
public float AttackSpeed { get; protected set; }
public float AttackDamageIncrease { get; protected set; }
public float AttackDamageMultiplier { get; protected set; }
///-Spells
public float SpellSkillLevel { get; protected set; }
public float CastSpeed { get; protected set; }
public float SpellDamageIncrease { get; protected set; }
public float SpellDamageMultiplier { get; protected set; }
///-Generic Offensive
public float AllSkillLevel { get; protected set; }
public float SupportSkillLevel { get; protected set; }
//Critical chance will be generic for both spells and attacks
public float criticalChance { get; protected set; }
public float criticalMultiplier { get; protected set; }
//Damageovertime
public float DamageOverTimeIncrease { get; protected set; }
public float DamageOverTimeMultiplier { get; protected set; }
//This affects the rate that damage over time ticks Default is 1 second
public float DamageOverTimeDuration { get; protected set; }
public float DamageOverTimeRateIncrease  { get; protected set; }
public float DamageOverTimeRateIncreaseMultiplier  { get; protected set; }
public float DamageOverTimeRateTotal  { get; protected set; }
//This resolves and removes the amount of damage that would've been dealt over a duration and deals it instantaneously 
public float DamageOverTimeResolutionDuration { get; protected set; }
public float DamageOverTimeResolutionDurationIncrease { get; protected set; }
public float DamageOverTimeResolutionDurationMultiplier { get; protected set; }
public float DamageOverTimeResolutionTotal { get; protected set; }
///-Physical
public float PhysicalDamageFlat { get; protected set; }
public float PhysicalDamageFlatMin { get; protected set; }
public float PhysicalDamageFlatMax { get; protected set; }
public float PhysicalDamageIncrease { get; protected set; }
public float PhysicalDamageMultiplier { get; protected set; }
public float PhysicalDamageOverTime { get; protected set; }
public float PhysicalDamageOverTimeIncrease { get; protected set; }
public float PhysicalDamageOverTimeMultiplier { get; protected set; }
//This is how much Physical damage over time you'll deal 
public float PhysicalDamageOverTimeRateTotal { get; protected set; }
//This is for Total Physical damage over time calculations
public float PhysicalDamageOverTimeTotal { get; protected set; }
//This is for Total Physical damage over time calculations After Reductions
public float PhysicalDamageOverTimeTotalNet { get; protected set; }
//This is for Total Physical hit damage calculations
public float PhysicalDamageHitTotal { get; protected set; }
//This is for total Physical damage display and calculations
public float PhysicalDamageTotal { get; protected set; }
//This is to print damage after monster resistance reduction at the end of calculations
public float PhysicalDamageTotalNet { get; protected set; }
///-Elemental
public float ElementalDamageFlat { get; protected set; }
public float ElementalDamageFlatMin { get; protected set; }
public float ElementalDamageFlatMax { get; protected set; }
public float ElementalDamageIncrease { get; protected set; }
public float ElementalDamageMultiplier { get; protected set; }
///Fire
public float FireSkillLevel { get; protected set; }
public float FireDamageFlat { get; protected set; }
public float FireDamageFlatMin { get; protected set; }
public float FireDamageFlatMax { get; protected set; }
public float FireDamageIncrease { get; protected set; }
public float FireDamageMultiplier { get; protected set; }
public float FireDamageOverTime { get; protected set; }
public float FireDamageOverTimeIncrease { get; protected set; }
public float FireDamageOverTimeMultiplier { get; protected set; }
//This is how much Fire damage over time you'll deal 
public float FireDamageOverTimeRateTotal { get; protected set; }
//This is for Total Fire damage over time calculations
public float FireDamageOverTimeTotal { get; protected set; }
//This is for Total Fire damage over time calculations after Reductions 
public float FireDamageOverTimeTotalNet { get; protected set; }
//This is for Total Fire hit damage calculations
public float FireDamageHitTotal { get; protected set; }
//This is for total Fire damage display and calculations
public float FireDamageTotal { get; protected set; }
//This is to print damage after monster resistance reduction at the end of calculations
public float FireDamageTotalNet { get; protected set; }
///Cold
public float ColdSkillLevel { get; protected set; }
public float ColdDamageFlat { get; protected set; }
public float ColdDamageFlatMin { get; protected set; }
public float ColdDamageFlatMax { get; protected set; }
public float ColdDamageIncrease { get; protected set; }
public float ColdDamageMultiplier { get; protected set; }
public float ColdDamageOverTime { get; protected set; }
public float ColdDamageOverTimeIncrease { get; protected set; }
public float ColdDamageOverTimeMultiplier { get; protected set; }
//This is how much Cold damage over time you'll deal 
public float ColdDamageOverTimeRateTotal{ get; protected set; }
//This is for Total Cold damage over time calculations
public float ColdDamageOverTimeTotal { get; protected set; }
//This is for Total Cold damage over time calculations after Reductions 
public float ColdDamageOverTimeTotalNet { get; protected set; }
//This is for Total Cold hit damage calculations
public float ColdDamageHitTotal { get; protected set; }
//This is for total Cold damage display and calculations
public float ColdDamageTotal { get; protected set; }
//This is to print damage after monster resistance reduction at the end of calculations
public float ColdDamageTotalNet { get; protected set; }
///Lightning
public float LightningSkillLevel { get; protected set; }
public float LightningDamageFlat { get; protected set; }
public float LightningDamageFlatMin { get; protected set; }
public float LightningDamageFlatMax { get; protected set; }
public float LightningDamageIncrease { get; protected set; }
public float LightningDamageMultiplier { get; protected set; }
public float LightningDamageHitTotal { get; protected set; }
//This is for total Lightning damage display and calculations
public float LightningDamageTotal { get; protected set; }
//This is to print damage after monster resistance reduction at the end of calculations
public float LightningDamageTotalNet { get; protected set; }
///--Defensive
///-Generic Defensive
public float DefensesIncrease { get; protected set; }
public float DefensesMultiplier { get; protected set; }
public float DamageReductionFlat { get; protected set; }
public float DamageReductionIncrease { get; protected set; }
public float DamageReductionMultiplier { get; protected set; }
//Evasion Capped at 60% chance to evade attacks & spells
public float EvasionFlat { get; protected set; }
public float EvasionIncrease { get; protected set; }
public float EvasionMultiplier { get; protected set; }
//amount of times evasion chance is rolled
public float EvasionLucky { get; protected set; }
//Block Soft-Capped at 60% chance to block attacks & Spells
public float AttackBlockFlat { get; protected set; }
public float AttackBlockIncrease { get; protected set; }
public float SpellBlockFlat { get; protected set; }
public float SpellBlockIncrease { get; protected set; }
//This is the max chance to block attacks & spells default 60%
public float BlockRatio { get; protected set; }
//Amount of times block chance is rolled
public float BlockLucky { get; protected set; }
public float AttackBlockLucky { get; protected set; }
public float SpellBlockLucky { get; protected set; }
//Life
public float LifeFlat { get; protected set; }
public float LifeIncrease { get; protected set; }
public float LifeMultiplier { get; protected set; }
public float LifeRecoupFlat { get; protected set; }
public float LifeRecoupIncrease { get; protected set; }
public float LifeRecoupMultiplier { get; protected set; }
public float LifeStealFlat { get; protected set; }
public float LifeStealPercent { get; protected set; }
public float LifeStealIncrease { get; protected set; }
public float LifeStealMultiplier { get; protected set; }
public float LifeRegenFlat { get; protected set; }
public float LifeRegenPerfect { get; protected set; }
public float LifeRegenIncrease { get; protected set; }
public float LifeRegenMultiplier { get; protected set; }
//Energyshield
public float EnergyShieldFlat { get; protected set; }
public float EnergyShieldIncrease { get; protected set; }
public float EnergyShieldMultiplier { get; protected set; }
public float EnergyShieldLeechFlat { get; protected set; }
public float EnergyShieldLeechPercent { get; protected set; }
public float EnergyShieldLeechIncrease { get; protected set; }
public float EnergyShieldLeechMultiplier { get; protected set; }
public float EnergyShieldRechargeInterval { get; protected set; }
public float EnergyShieldRechargeIntervalIncrease { get; protected set; }
public float EnergyShieldRechargeIntervalMultiplier { get; protected set; }
public float EnergyShieldRechargeSpeed { get; protected set; }
public float EnergyShieldRechargeSpeedIncrease { get; protected set; }
public float EnergyShieldRechargeSpeedMultiplier { get; protected set; }
//Armor Rating
public float ArmorFlat { get; protected set; }
public float ArmorIncrease { get; protected set; }
public float ArmorMultiplier { get; protected set; }
//Resistance
public float FireResistanceIncrease { get; protected set; }
public float FireResistanceTotal  { get; protected set; }
public float ColdResistanceIncrease { get; protected set; }
public float ColdResistanceTotal  { get; protected set; }
public float LightningResistanceIncrease { get; protected set; }
public float LightningResistanceTotal  { get; protected set; }
///--Passive
public float PassiveSkillLevel { get; protected set; }
public float AuraEffectIncrease { get; protected set; }
public float AuraEffectTotal { get; protected set; }
///--Buffs
//Harden Base 5% Damage reduction per stack of hardened the base max is 3
public float HardenStacksMin { get; protected set; }
public float HardenStacksMax { get; protected set; }
public float HardenEffect { get; protected set; }
///--Debuffs
//Stun
public float stunChance { get; protected set; }
public float stunSpeed { get; protected set; }
//Shock Base effect of shock is 10% more damage taken
public float ShockChance { get; protected set; }
public float ShockDuration { get; protected set; }
//Effective increase of shock
public float ShockEffect { get; protected set; }
//This is for Total Lightning hit damage calculations
// Shock-specific tracking
public bool IsTargetShocked { get; protected set; }
//This is the increase to shock's base effect which is 10% more damage taken 
public float ShockEffect { get; protected set; }
public float ShockStacksMin { get; protected set; }
public float ShockStacksMax { get; protected set; }
//This is to reference how many shock stacks are on the target currently
public float ShockStacksCurrent { get; protected set; }
//This is the shock total damage multiplier 
public float ShockTotal { get; protected set; }
///--Misc
//Cooldown Recovery
public float CooldownRecoveryFlat { get; protected set; }
public float CooldownRecoveryIncrease { get; protected set; }
public float CooldownRecoveryMultiplier { get; protected set; }
//Area of effect
public float SkillAoE { get; protected set; }
public float SkillAoEIncrease { get; protected set; }
public float SkillAoEMultiplier { get; protected set; }
//Mana
public float Mana { get; protected set; }
public float ManaIncrease { get; protected set; }
public float ManaMultiplier { get; protected set; }
public float ManaRegenFlat { get; protected set; }
public float ManaRegenPercent { get; protected set; }
public float ManaRegenIncrease { get; protected set; }
public float ManaRegenMultiplier { get; protected set; }
//Movementspeed
public float MovementSpeedFlat { get; protected set; }
public float MovementSpeedIncrease { get; protected set; }
public float MovementSpeedMultiplier { get; protected set; }
///--Damage Formulas
// this is a generic example (*DamageFlat × (1 + *Increase)) × (1 + *Multiplier)
// Physical Hit Damage
(PhysicalDamageFlat) x (1 + PhysicalDamageIncrease) x (1 + PhysicalDamageMultiplier) = PhysicalDamageHitTotal
// Physical DoT Rate Total (damage per dot not server tick)
(PhysicalDamageOverTime) x (1 + (PhysicalDamageOverTimeIncrease + DamageOverTimeIncrease)) x (1 + PhysicalDamageOverTimeMultiplier x DamageOverTimeMultiplier) x (1 + DamageOverTimeRateIncrease) x (1 + DamageOverTimeRateIncreaseMultiplier) = PhysicalDamageOverTimeRateTotal
// Physical DoT Total (over full duration)
(PhysicalDamageOverTimeRateTotal) x (DamageOverTimeDuration) = PhysicalDamageOverTimeTotal
// Total Physical Damage (Hit + DoT) before damage reductions ONLY FOR DISPLAY/UI
(PhysicalDamageHitTotal + PhysicalDamageOverTimeTotal) = PhysicalDamageTotal
//Fire Damage Calculations
// Fire Hit Damage
(FireDamageFlat + ElementalDamageFlat) x (1 + FireDamageIncrease + ElementalDamageIncrease) x (1 + FireDamageMultiplier) x (1 + ElementalDamageMultiplier) = FireDamageHitTotal
// Fire DoT Rate Total (damage per dot not server tick)
(FireDamageOverTime) x (1 + (FireDamageOverTimeIncrease + DamageOverTimeIncrease)) x (1 + FireDamageOverTimeMultiplier x DamageOverTimeMultiplier) x (1 + DamageOverTimeRateIncrease) x (1 + DamageOverTimeRateIncreaseMultiplier) = FireDamageOverTimeRateTotal
// Fire DoT Total (over full duration)
(FireDamageOverTimeRateTotal) x (DamageOverTimeDuration) = FireDamageOverTimeTotal
// Total Fire Damage (Hit + DoT) before damage reductions ONLY FOR DISPLAY/UI
(FireDamageHitTotal + FireDamageOverTimeTotal) = FireDamageTotal
//Cold Damage Calculations
// Cold Hit Damage
(ColdDamageFlat + ElementalDamageFlat) x (1 + ColdDamageIncrease + ElementalDamageIncrease) x (1 + ColdDamageMultiplier) x (1 + ElementalDamageMultiplier) = ColdDamageHitTotal
// Cold DoT Rate Total (damage per dot not server tick)
(ColdDamageOverTime) x (1 + (ColdDamageOverTimeIncrease + DamageOverTimeIncrease)) x (1 + ColdDamageOverTimeMultiplier x DamageOverTimeMultiplier) x (1 + DamageOverTimeRateIncrease) x (1 + DamageOverTimeRateIncreaseMultiplier) = ColdDamageOverTimeRateTotal
// Cold DoT Total (over full duration)
(ColdDamageOverTimeRateTotal) x (DamageOverTimeDuration) = ColdDamageOverTimeTotal
// Total Cold Damage (Hit + DoT) before damage reductions ONLY FOR DISPLAY/UI
(ColdDamageHitTotal + ColdDamageOverTimeTotal) = ColdDamageTotal
//Lightning Damage Calculations
//Lightning Hit Calc 
(LightningDamageFlat + ElementalDamageFlat )) x (1 + LightningDamageIncrease + ElementalDamageIncrease)) x (1 + LightningDamageMultiplier) x (1 + ElementalDamageMultiplier) = LightningDamageHitTotal
//Lightning Damage Total before damage reductions ONLY FOR DISPLAY/UI
(LightningDamageHitTotal) = LightningDamageTotal
// Debuff Formulas
if (IsTargetShocked == true)
{
    // Calculate shock multiplier: stacks × 10% base × shock effectiveness
    float shockTotal = (ShockStacksCurrent * 1.10f) * ShockEffect;
    // 'n' would be your shock damage multiplier to apply elsewhere
    // Example: finalDamage = baseDamage * shockTotal;
}
else
{
    // do nothing - target not shocked
    // shockTotal would be 1.0 (no effec	t)
}
#endif 