using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battery : MonoBehaviour
{
    [SerializeField] float restoreangle = 90f;
    [SerializeField] float addinten = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            other.GetComponentInChildren<flash>().restorelightangle(restoreangle);
            other.GetComponentInChildren<flash>().restorelightinten(addinten);
            Destroy(gameObject);
        }
    }
}
