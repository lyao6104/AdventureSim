// Anything specifically related to items goes in this file.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
	public string name;
	public string description;
	public string type;
	public string[] tags;
	public bool dropOnDeath = true;
}

/// <summary>
/// The Equipment class contains information relevant to both
/// Weapons and Armour. No Item should be *only* a piece of Equipment;
/// it should be either a Weapon, or Armour.
/// </summary>
[System.Serializable]
public abstract class Equipment : Item
{
	// Actors below this level cannot use this Equipment.
	public int level;
	// Only the specified races may use this Equipment. Leave empty to allow all.
	public string[] allowedRaces;
	// Weapon or Armour strength is multiplied against all of these to determine actual strength
	// for each damage type. Values do not have to add up to 100%.
	public DamageModifiers damageModifiers;
}

// Note that damage calculations aren't done by items, since damage can be affected by Actor stats.

/// <summary>
/// Weapons do damage, presumably against enemies.
/// </summary>
[System.Serializable]
public class Weapon : Equipment
{
	// Determines damage
	public int weaponStrength;
	public float criticalChance;
	public float accuracy;
}

/// <summary>
/// Armour reduces damage taken.
/// </summary>
[System.Serializable]
public class Armour : Equipment
{
	// Determines damage reduction
	public int armourStrength;
	// Chance to nullify a critical hit. Should be relatively low compared to criticalChance.
	public float criticalResistance;
}
