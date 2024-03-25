using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ScreenShake : MonoBehaviour
{

    [SerializeField] CinemachineVirtualCamera vcam;
    float timer = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1.0f * Time.deltaTime;
        Debug.Log(timer);
    }

    public void StartShake()
    {
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 100;
        timer = 0.0f;
        while (timer < 2.0f)
        {
            //Do nothing
        }
        EndShake();
    }
    
    public void EndShake()
    {
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0;
    }
}
