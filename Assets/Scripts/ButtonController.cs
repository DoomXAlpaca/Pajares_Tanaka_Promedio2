using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Text scoreText;

    private void Start()
    {
        button1.onClick.AddListener(IncrementScoreBy1);
        button2.onClick.AddListener(IncrementScoreBy2);
        button3.onClick.AddListener(IncrementScoreBy3);
    }

    private void IncrementScoreBy1()
    {
        GameManager.Instance.IncrementScore(1);
    }

    private void IncrementScoreBy2()
    {
        GameManager.Instance.IncrementScore(2);
    }

    private void IncrementScoreBy3()
    {
        GameManager.Instance.IncrementScore(3);
    }

    private void Update()
    {
        scoreText.text = "Score: " + GameManager.Instance.Score;
    }
}
