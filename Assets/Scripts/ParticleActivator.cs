using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleActivator : MonoBehaviour
{
    [SerializeField] ParticleSystem ps;
    [SerializeField] GameObject barrelEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
 
    }

    public void Emit()
    {
        this.transform.position = barrelEnd.transform.position;
        this.transform.rotation = barrelEnd.transform.rotation;
        ps.Play();
    }
}
