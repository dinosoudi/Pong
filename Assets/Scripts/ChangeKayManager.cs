using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeKayManager : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private ControlMenuButtons controlMenuButtons;
    bool up = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
                    controlMenuButtons.EnableDisenableButtons();
                }
            }
        }
    }
    public void SetBoolValue(bool upOrDown)
    {
        up = upOrDown;
    }

    public void SetTextField(Text textField)
    {
        text = textField;
    }
}
