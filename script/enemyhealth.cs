using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    [SerializeField] float htpt = 100f;
    
    bool isdead = false;
   
    public void takedamage(float damage)
    {
        BroadcastMessage("Takedam");
        htpt -= damage;
        if (htpt <= 0)
        {
            Die();
        }
    }
    public bool Isdead()
    {
        return isdead;
    }

    [Obsolete]
    private void Die()
    {
        
        if (isdead) return;
        isdead = true;
        GetComponent<Animator>().SetTrigger("die");
        stopmus();
    }

    public void stopmus()
    {
        Destroy(GetComponent<AudioSource>());
    }
}
