using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class aimout : MonoBehaviour
{
    [SerializeField] Camera fps;
    [SerializeField] float zoomin = 20f;
    [SerializeField] float zoomout = 60f;
    [SerializeField] float zoomoutsen = 2f;
    [SerializeField] float zoominsen = 0.5f;
    [SerializeField] RigidbodyFirstPersonController fpsc;
    bool zoomt = false;

    private void OnDisable()
    {
        zoomO();
    }
    private void Start()
    {
        fpsc = GetComponentInParent<RigidbodyFirstPersonController>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) {
            if(zoomt==false)
            {
                zoomI();
            }
            else
            {
                zoomO();
            }
        }
    }

    private void zoomO()
    {
        zoomt = false;
        fps.fieldOfView = zoomout;
        fpsc.mouseLook.XSensitivity = zoomoutsen;
        fpsc.mouseLook.YSensitivity = zoomoutsen;
    }

    private void zoomI()
    {
        zoomt = true;
        fps.fieldOfView = zoomin;
        fpsc.mouseLook.XSensitivity = zoominsen;
        fpsc.mouseLook.YSensitivity = zoominsen;
    }
}
