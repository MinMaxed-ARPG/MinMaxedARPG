
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public float AttackSkillLevel { get; protected set; } = 0f;
    // public float { get; protected set; }

    ///--Offensive
    ///-Attacks
    //public float AttackSkillLevel { get; protected set; } = 0f;
    public float AttackSpeed { get; protected set; } = 1f;
    public float AttackDamageIncrease { get; protected set; } = 1f;
    public float AttackDamageMultiplier { get; protected set; } = 1f;
    ///-Spells
    public float SpellSkillLevel { get; protected set; } = 0f;
    public float CastSpeed { get; protected set; } = 1f;
    public float SpellDamageIncrease { get; protected set; } = 1f;
    public float SpellDamageMultiplier { get; protected set; } = 1f;
    ///-Generic Offensive
    public float AllSkillLevel { get; protected set; } = 0f;
    public float SupportSkillLevel { get; protected set; } = 0f;
    //Critical chance will be generic for both spells and attacks
    public float criticalChance { get; protected set; } = 1f;
    public float criticalMultiplier { get; protected set; } = 1f;
    //Damageovertime
    public float DamageOverTimeIncrease { get; protected set; } = 1f;
    public float DamageOverTimeMultiplier { get; protected set; } = 1f;
//This affects the rate that damage over time ticks Default is 1 second
public float DamageOverTimeDuration { get; protected set; } = 1f;
    public float DamageOverTimeRateIncrease { get; protected set; } = 1f;
    public float DamageOverTimeRateIncreaseMultiplier { get; protected set; } = 1f;
    public float DamageOverTimeRateTotal { get; protected set; } = 0f;
    //This resolves and removes the amount of damage that would've been dealt over a duration and deals it instantaneously 
    public float DamageOverTimeResolutionDuration { get; protected set; } = 0f;
    public float DamageOverTimeResolutionDurationIncrease { get; protected set; } = 0f;
    public float DamageOverTimeResolutionDurationMultiplier { get; protected set; } = 0f;
    public float DamageOverTimeResolutionTotal { get; protected set; } = 0f;
    ///-Physical
    public float PhysicalDamageFlat { get; protected set; } = 0f;
    public float PhysicalDamageFlatMin { get; protected set; } = 0f;
    public float PhysicalDamageFlatMax { get; protected set; } = 0f;
    public float PhysicalDamageIncrease { get; protected set; } = 1f;
    public float PhysicalDamageMultiplier { get; protected set; } = 1f;
    public float PhysicalDamageOverTime { get; protected set; } = 0f;
    public float PhysicalDamageOverTimeIncrease { get; protected set; } = 1f;
    public float PhysicalDamageOverTimeMultiplier { get; protected set; } = 1f;
    //This is how much Physical damage over time you'll deal 
    public float PhysicalDamageOverTimeRateTotal { get; protected set; } = 0f;
    //This is for Total Physical damage over time calculations
    public float PhysicalDamageOverTimeTotal { get; protected set; } = 0f;
    //This is for Total Physical damage over time calculations After Reductions
    public float PhysicalDamageOverTimeTotalNet { get; protected set; } = 0f;
    //This is for Total Physical hit damage calculations
    public float PhysicalDamageHitTotal { get; protected set; } = 0f;
    //This is for total Physical damage display and calculations
    public float PhysicalDamageTotal { get; protected set; } = 0f;
    //This is to print damage after monster resistance reduction at the end of calculations
    public float PhysicalDamageTotalNet { get; protected set; }
    ///-Elemental
    public float ElementalDamageFlat { get; protected set; } = 0f;
    public float ElementalDamageFlatMin { get; protected set; } = 0f;
    public float ElementalDamageFlatMax { get; protected set; } = 0f;
    public float ElementalDamageIncrease { get; protected set; } = 1f;
    public float ElementalDamageMultiplier { get; protected set; } = 1f;
    ///Fire
    public float FireSkillLevel { get; protected set; } = 0f;
    public float FireDamageFlat { get; protected set; } = 0f;
    public float FireDamageFlatMin { get; protected set; } = 0f;
    public float FireDamageFlatMax { get; protected set; } = 0f;
    public float FireDamageIncrease { get; protected set; } = 1f;
    public float FireDamageMultiplier { get; protected set; } = 1f;
    public float FireDamageOverTime { get; protected set; } = 0f;
    public float FireDamageOverTimeIncrease { get; protected set; } = 1f;
    public float FireDamageOverTimeMultiplier { get; protected set; } = 1f;
    //This is how much Fire damage over time you'll deal 
    public float FireDamageOverTimeRateTotal { get; protected set; } = 0f;
    //This is for Total Fire damage over time calculations
    public float FireDamageOverTimeTotal { get; protected set; } = 0f;
    //This is for Total Fire damage over time calculations after Reductions 
    public float FireDamageOverTimeTotalNet { get; protected set; } = 0f;
    //This is for Total Fire hit damage calculations
    public float FireDamageHitTotal { get; protected set; } = 0f;
    //This is for total Fire damage display and calculations
    public float FireDamageTotal { get; protected set; } = 0f;
    //This is to print damage after monster resistance reduction at the end of calculations
    public float FireDamageTotalNet { get; protected set; } = 0f;
    ///Cold
    public float ColdSkillLevel { get; protected set; } = 0f;
    public float ColdDamageFlat { get; protected set; } = 0f;
    public float ColdDamageFlatMin { get; protected set; } = 0f;
    public float ColdDamageFlatMax { get; protected set; } = 0f;
    public float ColdDamageIncrease { get; protected set; } = 1f;
    public float ColdDamageMultiplier { get; protected set; } = 1f;
    public float ColdDamageOverTime { get; protected set; } = 0f;
    public float ColdDamageOverTimeIncrease { get; protected set; } = 1f;
    public float ColdDamageOverTimeMultiplier { get; protected set; } = 1f;
    //This is how much Cold damage over time you'll deal 
    public float ColdDamageOverTimeRateTotal { get; protected set; } = 0f;
    //This is for Total Cold damage over time calculations
    public float ColdDamageOverTimeTotal { get; protected set; } = 0f;
    //This is for Total Cold damage over time calculations after Reductions 
    public float ColdDamageOverTimeTotalNet { get; protected set; } = 0f;
    //This is for Total Cold hit damage calculations
    public float ColdDamageHitTotal { get; protected set; } = 0f;
    //This is for total Cold damage display and calculations
    public float ColdDamageTotal { get; protected set; } = 0f;
    //This is to print damage after monster resistance reduction at the end of calculations
    public float ColdDamageTotalNet { get; protected set; } = 0f;
    ///Lightning
    public float LightningSkillLevel { get; protected set; } = 0f;
    public float LightningDamageFlat { get; protected set; } = 0f;
    public float LightningDamageFlatMin { get; protected set; } = 0f;
    public float LightningDamageFlatMax { get; protected set; } = 0f;
    public float LightningDamageIncrease { get; protected set; } = 1f;
    public float LightningDamageMultiplier { get; protected set; } = 1f;
    public float LightningDamageHitTotal { get; protected set; } = 0f;
    //This is for total Lightning damage display and calculations
    public float LightningDamageTotal { get; protected set; } = 0f;
    //This is to print damage after monster resistance reduction at the end of calculations
    public float LightningDamageTotalNet { get; protected set; } = 0f;
    ///Minions
    public float MinionLife { get; protected set; } = 0f;
    public float MinionLifeIncrease { get; protected set; } = 1f;
    public float MinionLifeMultiplier { get; protected set; } = 1f;
    public float MinionAttackSpeed { get; protected set; } = 1f;
    public float MinionCastSpeed { get; protected set; } = 1f;
    public float MinionCriticalChance { get; protected set; } = 1f;
    public float MinionCriticalMultiplier { get; protected set; } = 1f;
    public float MinionMovementSpeedFlat { get; protected set; } = 0f;
    public float MinionMovementSpeedIncrease { get; protected set; } = 1f;
    public float MinionMovementSpeedMultiplier { get; protected set; } = 1f;

    ///--Defensive
    ///-Generic Defensive
    public float DefensesIncrease { get; protected set; } = 1f;
    public float DefensesMultiplier { get; protected set; } = 1f;
    public float DamageReductionFlat { get; protected set; } = 0f;
    public float DamageReductionIncrease { get; protected set; } = 1f;
    public float DamageReductionMultiplier { get; protected set; } = 1f;
    //Evasion Capped at 60% chance to evade attacks & spells
    public float EvasionFlat { get; protected set; } = 0f;
    public float EvasionIncrease { get; protected set; } = 1f;
    public float EvasionMultiplier { get; protected set; } = 1f;
    //amount of times evasion chance is rolled
    public float EvasionLucky { get; protected set; } = 0f;
    //Block Soft-Capped at 60% chance to block attacks & Spells
    public float AttackBlockFlat { get; protected set; } = 0f;
    public float AttackBlockIncrease { get; protected set; } = 1f;
    public float SpellBlockFlat { get; protected set; } = 0f;
    public float SpellBlockIncrease { get; protected set; } = 1f;
    //This is the max chance to block attacks & spells default 60%
    public float BlockRatio { get; protected set; } = 1f;
    //Amount of times block chance is rolled
    public float BlockLucky { get; protected set; } = 0f;
    public float AttackBlockLucky { get; protected set; } = 0f;
    public float SpellBlockLucky { get; protected set; } = 0f;
    //Life
    public float LifeFlat { get; protected set; } = 0f;
    public float LifeIncrease { get; protected set; } = 1f;
    public float LifeMultiplier { get; protected set; } = 1f;
    public float LifeRecoupFlat { get; protected set; } = 0f;
    public float LifeRecoupIncrease { get; protected set; } = 1f;
    public float LifeRecoupMultiplier { get; protected set; } = 1f;
    public float LifeStealFlat { get; protected set; } = 0f;
    public float LifeStealPercent { get; protected set; } = 0f;
    public float LifeStealIncrease { get; protected set; } = 1f;
    public float LifeStealMultiplier { get; protected set; } = 1f;
    public float LifeRegenFlat { get; protected set; } = 0f;
    public float LifeRegenPercent { get; protected set; } = 1f;
    public float LifeRegenIncrease { get; protected set; } = 1f;
    public float LifeRegenMultiplier { get; protected set; } = 1f;
    //Energyshield
    public float EnergyShieldFlat { get; protected set; } = 0f;
    public float EnergyShieldIncrease { get; protected set; } = 1f;
    public float EnergyShieldMultiplier { get; protected set; } = 1f;
    public float EnergyShieldLeechFlat { get; protected set; } = 0f;
    public float EnergyShieldLeechPercent { get; protected set; } = 1f;
    public float EnergyShieldLeechIncrease { get; protected set; } = 1f;
    public float EnergyShieldLeechMultiplier { get; protected set; } = 1f;
    public float EnergyShieldRechargeInterval { get; protected set; } = 1f;
    public float EnergyShieldRechargeIntervalIncrease { get; protected set; } = 1f;
    public float EnergyShieldRechargeIntervalMultiplier { get; protected set; } = 1f;
    public float EnergyShieldRechargeSpeed { get; protected set; } = 1f;
    public float EnergyShieldRechargeSpeedIncrease { get; protected set; } = 1f;
    public float EnergyShieldRechargeSpeedMultiplier { get; protected set; } = 1f;
    //Armor Rating
    public float ArmorFlat { get; protected set; } = 0f;
    public float ArmorIncrease { get; protected set; } = 1f;
    public float ArmorMultiplier { get; protected set; } = 1f;
    //Resistance
    public float FireResistanceIncrease { get; protected set; } = 0f;
    public float FireResistanceTotal { get; protected set; } = 0f;
    public float ColdResistanceIncrease { get; protected set; } = 0f;
    public float ColdResistanceTotal { get; protected set; } = 0f;
    public float LightningResistanceIncrease { get; protected set; } = 0f;
    public float LightningResistanceTotal { get; protected set; } = 0f;
    ///--Passive
    public float PassiveSkillLevel { get; protected set; } = 0f;
    public float AuraEffectIncrease { get; protected set; } = 1f;
    public float AuraEffectTotal { get; protected set; } = 0f;
    ///--Buffs
    //Harden Base 5% Damage reduction per stack of hardened the base max is 3
    public float HardenStacksMin { get; protected set; } = 0f;
    public float HardenStacksMax { get; protected set; } = 0f;
    public float HardenEffect { get; protected set; } = 1f;
    ///--Debuffs
    //Stun
    public float stunChance { get; protected set; } = 0f;
    public float stunSpeed { get; protected set; } = 0f;
    //Shock Base effect of shock is 10% more damage taken
    public float ShockChance { get; protected set; } = 0f;
    public float ShockDuration { get; protected set; } = 0f;
    //Effective increase of shock
    public float ShockEffect { get; protected set; } = 0f;
    //This is for Total Lightning hit damage calculations
    // Shock-specific tracking
    public float IsTargetShocked { get; protected set; } = 0f;
    //This is the increase to shock's base effect which is 10% more damage taken 
    //public float ShockEffect { get; protected set; } = 1f;
    public float ShockStacksMin { get; protected set; } = 0f;
    public float ShockStacksMax { get; protected set; } = 0f;
    //This is to reference how many shock stacks are on the target currently
    public float ShockStacksCurrent { get; protected set; } = 0f;
    //This is the shock total damage multiplier 
    public float ShockTotal { get; protected set; } = 0f;
    ///--Misc
    //Cooldown Recovery
    public float CooldownRecoveryFlat { get; protected set; } = 0f;
    public float CooldownRecoveryIncrease { get; protected set; } = 1f;
    public float CooldownRecoveryMultiplier { get; protected set; } = 1f;
    //Area of effect
    public float SkillAoE { get; protected set; } = 1f;
    public float SkillAoEIncrease { get; protected set; } = 1f;
    public float SkillAoEMultiplier { get; protected set; } = 1f;
    //Mana
    public float Mana { get; protected set; } = 1f;
    public float ManaIncrease { get; protected set; } = 1f;
    public float ManaMultiplier { get; protected set; } = 1f;
    public float ManaRegenFlat { get; protected set; } = 0f;
    public float ManaRegenPercent { get; protected set; } = 1f;
    public float ManaRegenIncrease { get; protected set; } = 1f;
    public float ManaRegenMultiplier { get; protected set; } = 1f;
    //Movementspeed
    public float MovementSpeedFlat { get; protected set; }
    public float MovementSpeedIncrease { get; protected set; }
    public float MovementSpeedMultiplier { get; protected set; }
}
#if DISABLE_TEMP_FILE
// Wrapped in an if / end if so it doesnt compile
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