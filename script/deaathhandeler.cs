using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deaathhandeler : MonoBehaviour
{
    [SerializeField] Canvas death;
    void Start()
    {
        death.enabled = false;
    }

    // Update is called once per frame
    public void handeldeath()
    {
        death.enabled = true;
        Time.timeScale = 0;
        FindObjectOfType<weaponswitch>().enabled = false;
        FindObjectOfType<weapon>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
