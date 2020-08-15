using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammopickup : MonoBehaviour
{
    [SerializeField] int ammoammout = 10;
    [SerializeField] ammotype ammotype;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<ammo>().increasecurrentammo(ammotype, ammoammout);
            Destroy(gameObject);
        }
    }
}
