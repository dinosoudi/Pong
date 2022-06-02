using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

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

    public void ShowControlsMenu()
    {

    }
}
