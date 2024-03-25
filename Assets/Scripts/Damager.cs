using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    FPSController player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<FPSController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void hurtPlayer()
    {
        player.health -= 1.0f;
    }
}
