using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] Image healthBar;
    [SerializeField] TMP_Text currentAmmoText;
    [SerializeField] TMP_Text maxAmmoText;

    FPSController player;
    Gun currentGun;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<FPSController>();
        currentGun = FindObjectOfType<Gun>();
        maxAmmoText.text = currentGun.maxAmmo.ToString();
        currentAmmoText.text = currentGun.maxAmmo.ToString();
    }

    void Update()
    {
        
    }

    public void UpdateAmmo()
    {
        currentGun = player?.GetCurrentGun();
        currentAmmoText.text = currentGun.ammo.ToString();
    }
}
