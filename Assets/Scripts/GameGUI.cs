using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameGUI : MonoBehaviour
{
    public Image healthBar;
    public TextMeshProUGUI ammoText;
     
    public void SetAmmoInfo(int totalAmmo, int ammoInMag)
    {
        ammoText.text = "Ammo - " + ammoInMag + "/" + totalAmmo;
    }
}
