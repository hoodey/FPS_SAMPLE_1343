using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refiller : MonoBehaviour
{

    FPSController player;
    Gun currentGun;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<FPSController>();
        currentGun = FindObjectOfType<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RefillAmmo()
    {
        currentGun.ammo = currentGun.maxAmmo;
    }
}
