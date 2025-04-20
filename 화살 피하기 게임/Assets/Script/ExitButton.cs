using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{


    public void Quit()
    {
        Debug.Log("게임 종료");
        Application.Quit();
    }




}
