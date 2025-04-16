using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject hpGauge;
    // Start is called before the first frame update
    void Start()
    {
        // hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame

    public void DecreaseHP()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
    public void ExitButtonDown()
    {
        
    }
}
