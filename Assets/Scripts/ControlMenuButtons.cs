using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlMenuButtons : MonoBehaviour
{
    [SerializeField] private Button upChangeButton;
    [SerializeField] private Button downChangeButton;
    [SerializeField] private Dropdown player1Dropdown;
    bool activeButtons = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableDisenableButtons()
    {
        if (activeButtons)
        {
            upChangeButton.interactable = false;
            downChangeButton.interactable = false;
            player1Dropdown.interactable = false;
        }
        else
        {
            upChangeButton.interactable = true;
            downChangeButton.interactable = true;
            player1Dropdown.interactable = true;
        }
        activeButtons = !activeButtons;
    }
}
