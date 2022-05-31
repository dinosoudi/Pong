using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMenu : MonoBehaviour
{
    public void Select1Player()
    {
        PlayerControler.Instance.SetPlayers(1);
    }
}
