using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private GameObject paddle1;
    [SerializeField] private GameObject paddle2;
    [SerializeField] private GameObject ball;
    [SerializeField] private Text counter;
    float textTime = 3f;
    int actualValue;
    // Start is called before the first frame update
    void Start()
    {
        ball.SetActive(false);
        counter.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        actualValue = (int)textTime;
        textTime -= Time.deltaTime;
        if (actualValue != (int)textTime) {
            counter.text = actualValue.ToString();
        }
        if (textTime <= 0) {
            ball.SetActive(true);
            counter.gameObject.SetActive(false);
            gameObject.SetActive(false);
            paddle1.GetComponent<PlayerMovement>().SetMove(true);
            //paddle2.GetComponent<PlayerMovement>().SetMove(true);
            paddle2.GetComponent<IAMovement>().SetMove(true);
        }
    }

    public void Reiniciate()
    {
        textTime = 3f;
        gameObject.SetActive(true);
        counter.gameObject.SetActive(true);
        paddle1.GetComponent<PlayerMovement>().SetMove(false);
        //paddle2.GetComponent<PlayerMovement>().SetMove(false);
        paddle2.GetComponent<IAMovement>().SetMove(true);
    }
}
