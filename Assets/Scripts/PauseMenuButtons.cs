using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuButtons : MonoBehaviour
{
    public void ChangeTextButtonOnOff(Text textM)
    {
        if (textM.text.Equals("On"))
        {
            textM.text = "Off";
        }
        else
        {
            textM.text = "On";
        }
    }
}
