using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Powerups/HealthBuff")]
public class HealthBuff : PowerupEffect
    
{
    public int amount;
    public override void Apply(GameObject target)
    {
        GameManager.gameManager.player.PlayerHeal(amount);
        Debug.Log(amount);
    }
}
