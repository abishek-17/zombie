using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damdis : MonoBehaviour
{
    [SerializeField] Canvas impact;
    [SerializeField] float impacttime = 0.3f;
    void Start()
    {
        impact.enabled = false;
    }

    public void showdamage() {
        StartCoroutine(showimpact());
    }
    IEnumerator showimpact() {
        impact.enabled = true;
        yield return new WaitForSeconds(impacttime);
        impact.enabled = false;
    }
}
