using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PotionDate", menuName = "ScriptableObjects/Potion", order = 0)]

public class PotionData : ScriptableObject
{
    public PotionEffect itemEffect;
    public float amount;
}

public enum PotionEffect
{
    None,
    Slow,
    Speed,
    Heal,
    Damage,
    AddMana,
    RemoveMana,
    Max,
    }