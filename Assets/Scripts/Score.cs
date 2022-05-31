using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;
    [SerializeField] private Text score1;
    [SerializeField] private Text score2;
    [SerializeField] private GameObject paddle1;
    [SerializeField] private GameObject paddle2;
    [SerializeField] private GameObject counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScorePlayer1(int value) {
        scorePlayer1 += value;
        score1.text = scorePlayer1.ToString();
        IncrementScore();
    }

    public void IncrementScorePlayer2(int value) {
        scorePlayer2 += value;
        score2.text = scorePlayer2.ToString();
        IncrementScore();
    }

    void IncrementScore() {
        paddle1.GetComponent<PlayerMovement>().RestartPaddle();
        paddle2.GetComponent<IAMovement>().RestartPaddle();
        counter.GetComponent<Counter>().Reiniciate();
    }
}
