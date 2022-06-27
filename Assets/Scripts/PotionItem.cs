using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionItem : AItem
{
    public PotionData data;
    public override void use()
    {
        if (data == null) return;
        switch (data.itemEffect)
        {
            case PotionEffect.Heal:
                PlayerRef.HP += 5f;
                break;
            case PotionEffect.Damage:
                break;
            case PotionEffect.Slow:
                PlayerRef.Speed = 5f;
                break;
            case PotionEffect.Speed:
                PlayerRef.Speed = 15f;
                break;
            case PotionEffect.AddMana:
                PlayerRef.MP += 5f;
                break;
            case PotionEffect.RemoveMana:
                PlayerRef.MP -= 5f;
                break;
        }

    }
}