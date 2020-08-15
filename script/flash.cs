using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flash : MonoBehaviour
{
    [SerializeField] float lightdecay = 0.1f;
    [SerializeField] float angledecay=1f;
    [SerializeField] float minangle=40f;
    Light mylight;
    void Start()
    {
        mylight = GetComponent<Light>();
    }
    
    // Update is called once per frame
    void Update()
    {
        declightangle();
        declightint();
    }
    public void restorelightangle( float restoreangle) {
        mylight.spotAngle = restoreangle;
    }
    public void restorelightinten(float restoreint)
    {
        mylight.spotAngle += restoreint;
    }

    private void declightint()
    {
        mylight.spotAngle -= lightdecay * Time.deltaTime;
    }

    private void declightangle()
    {
        if (mylight.spotAngle<= minangle) {
            return;
        }
        else
        {
            mylight.spotAngle -= angledecay * Time.deltaTime;
        }
        
    }
}
