using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GunAim : MonoBehaviour
{
    [SerializeField] FPSController controller;
    [SerializeField] LayerMask shootableLayers;
    [SerializeField] LayerMask interactableLayers;
    [SerializeField] Transform gun;
    [SerializeField] Image crosshair;
    [SerializeField] Transform barrelEnd;

    [SerializeField] Color colorValidTarget;
    [SerializeField] Color colorNoValidTarget;

    [SerializeField] UnityEvent OnInteract;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InteractAim();
        Aim();
    }

    void InteractAim()
    {
        RaycastHit hit;
        Vector3 start = controller.Cam.transform.position;
        Vector3 forward = controller.Cam.transform.forward;

        if (Physics.Raycast(start, forward, out hit, 1.0f, interactableLayers) && Input.GetButtonDown("Interact"))
        {
            OnInteract.Invoke();
        }
    }

    void Aim()
    {
        RaycastHit hit;
        Vector3 start = controller.Cam.transform.position;
        Vector3 forward = controller.Cam.transform.forward;

        if (Physics.Raycast(start, forward, out hit, 1000.0f, shootableLayers))
        {
            barrelEnd.LookAt(hit.point);
            crosshair.color = colorValidTarget;
            return;
        }

        crosshair.color = colorNoValidTarget;
        //gun.forward = forward;
        barrelEnd.forward = forward;
    }
}
