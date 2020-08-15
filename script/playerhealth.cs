using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    [SerializeField] float htpt = 100f;
    [SerializeField] TextMeshProUGUI amttext;
    public void Update()
    {
      displayhealth();
   }
    public void takedamage(float damage)
    {
        htpt -= damage;
        if (htpt <= 0)
        {
            GetComponent<deaathhandeler>().handeldeath();
        }
    }
    private void displayhealth()
   {
       float currenthealth = htpt;
        amttext.text = currenthealth.ToString();
    }
}
