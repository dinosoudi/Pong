using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMenu : MonoBehaviour
{
    public void SelectPlayers(int players)
    {
        PlayerController.Instance.SetPlayers(players);
    }
}
