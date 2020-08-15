using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class eneAI : MonoBehaviour
{
    [SerializeField] float chase = 5f;
    [SerializeField] float turnspeed = 5f;
    NavMeshAgent navMeshAgent;
    float dtt = Mathf.Infinity;
    bool isproveked = false;
    enemyhealth health;
    Transform trg;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        health = GetComponent<enemyhealth>();
        trg = FindObjectOfType<playerhealth>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (health.Isdead())
        {
            enabled = false;
            navMeshAgent.enabled = false;

        }
        dtt = Vector3.Distance(trg.position,transform.position);
        if (isproveked) {
            engagetarget();
        }
        else if (dtt <= chase)
        {
            isproveked = true;
        }
       
    }
    public void Takedam() {

        isproveked = true;
    }
    public void engagetarget()
    {
        facetarget();
        if (dtt >= navMeshAgent.stoppingDistance)
        {
            chasetarget();
            playmu(); 
            
        }
        if (dtt <= navMeshAgent.stoppingDistance)
        {
            attacktarget();
        }
        
    }

     void playmu()
    {
        FindObjectOfType<AudioSource>().Play();
    }

    private void chasetarget()
    {
        GetComponent<Animator>().SetBool("attack", false);
        GetComponent<Animator>().SetTrigger("move");
        navMeshAgent.destination = trg.position;
    }

    private void attacktarget()
    {
        GetComponent<Animator>().SetBool("attack", true);
        print("attacking player" + name);
    }

    public void facetarget() {
        Vector3 dir = (trg.position - transform.position).normalized;
        Quaternion lr = Quaternion.LookRotation(new Vector3(dir.x,0,dir.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lr, Time.deltaTime * turnspeed);
    }
    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, chase);
    }
}
