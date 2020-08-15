using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    [SerializeField] ammoslot[] ammoSlot;
    [System.Serializable]
    private class ammoslot
    {
        public ammotype ammotype;
        public int ammoammount;

    }
   public int getcurrentammo(ammotype ammotype)
    {
        return GetAmmoslot(ammotype).ammoammount;
    }

    // Update is called once per frame
   public void reducecurrentammo(ammotype ammotype)
    {
        GetAmmoslot(ammotype).ammoammount--;
    }
    public void increasecurrentammo(ammotype ammotype, int ammoamount)
    {
        GetAmmoslot(ammotype).ammoammount += ammoamount;
    } 
    private ammoslot GetAmmoslot(ammotype ammotype) {
        foreach (ammoslot slot in ammoSlot) {
            if (slot.ammotype==ammotype) {
                return slot;
            }

        }
        return null;
    }
}
