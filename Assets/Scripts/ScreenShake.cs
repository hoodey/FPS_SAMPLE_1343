using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ScreenShake : MonoBehaviour
{

    [SerializeField] CinemachineVirtualCamera vcam;
    float camShake = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartShake()
    {
        camShake = 100;
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = camShake;
        StartCoroutine(ShakeFade());
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = camShake;
    }
    
    IEnumerator ShakeFade()
    {
        yield return new WaitForSeconds(2.0f);
        camShake = 0;
    }

}
