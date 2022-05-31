using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public static PlayerControler Instance;
    [SerializeField] private int players;
    private void Awake()
    {
        if(PlayerControler.Instance == null)
        {
            PlayerControler.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetPlayers(int p)
    {
        players = p;
        Debug.Log("Players: " + players);
    }
}
