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
        camShake = 1;
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = camShake;
        StartCoroutine(ShakeFade());
    }
    
    IEnumerator ShakeFade()
    {
        for (float i = 1.0f; i >= 0.1f; i -= 0.2f)
        {
            camShake = i;
            vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = camShake;
            yield return new WaitForSeconds(.1f);
        }
        camShake = 0;
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = camShake;
    }

}
