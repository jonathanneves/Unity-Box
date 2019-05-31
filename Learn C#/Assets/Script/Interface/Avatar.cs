using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
{
    float health = 100f;

    public void Kill()
    {
        if (health <= 0)
            print("Você morreu!");
    }

    public void Damage(float damageTaken)
    {
        health -= damageTaken;
    }
}
