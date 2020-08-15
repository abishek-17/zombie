using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eneattack : MonoBehaviour
{
    playerhealth target;
    [SerializeField] float damage = 40f;
    void Start()
    {
        target = FindObjectOfType<playerhealth>();
    }
    public void attackhit()
    {
        if (target == null) {
            return;
        }
        target.takedamage(damage);
        target.GetComponent<damdis>().showdamage();
    }
}
