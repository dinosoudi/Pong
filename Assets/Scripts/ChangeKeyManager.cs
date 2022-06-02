using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeKeyManager : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private ControlMenuButtons controlMenuButtons;
    bool up = true;

    public void OnGUI()
    {
        if (Input.anyKeyDown)
        {
            Event e = Event.current;
            if (e.isKey)
            {
                if (e.keyCode.ToString() != "Escape" && e.keyCode.ToString() != "None") 
                {
                    text.text = e.keyCode.ToString();
                    if (up)
                    {
                        playerMovement.up = e.keyCode;
                    }
                    else
                    {
                        playerMovement.down = e.keyCode;
                    }
                    gameObject.SetActive(false);
                    controlMenuButtons.ChangeActiveButtons();
                }
            }
        }
    }
    public void UpKeyControl(bool isUp)
    {
        up = isUp;
    }

    public void SetTextField(Text textField)
    {
        text = textField;
    }
}
