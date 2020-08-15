using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class weapon : MonoBehaviour
{
    [SerializeField] Camera FPC;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 30f;
    [SerializeField] ParticleSystem mf;
    [SerializeField] GameObject hf;
    [SerializeField] ammo ammoslot;
    [SerializeField] ammotype ammotype;
    [SerializeField] float timebtwshots = 0.5f;
    [SerializeField] TextMeshProUGUI amttext;
    [SerializeField] AudioSource aud;
    bool canshoot = true;

    private void OnEnable()
    {
        canshoot = true;
    }
    void Update()
    {
        displayammo();
        if (Input.GetMouseButtonDown(0) && canshoot == true) {
            StartCoroutine(shoot());

            if (ammoslot.getcurrentammo(ammotype) > 0) {
                aud.Play();
            }

        }
    }

    private void displayammo()
    {
        int currentammo = ammoslot.getcurrentammo(ammotype);
        amttext.text = currentammo.ToString();
    }   

    IEnumerator shoot()
    {
        canshoot = false;
        if (ammoslot.getcurrentammo(ammotype)>0) {
            playmf();
            processray();
            ammoslot.reducecurrentammo(ammotype);
        }
        yield return new WaitForSeconds(timebtwshots);
        canshoot = true;
    }

    private void playmf()
    {
        mf.Play();
    }

    private void processray()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPC.transform.position, FPC.transform.forward, out hit, range))
        {
            createhiteffect(hit);
            enemyhealth target = hit.transform.GetComponent<enemyhealth>();
            if (target == null) return;
            target.takedamage(damage);

        }
        else
        {
            return;
        }
    }

    private void createhiteffect(RaycastHit hit)
    {
      GameObject impact =  Instantiate(hf, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact, 1);
    }
}
