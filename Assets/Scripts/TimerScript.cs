using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private float timeLeft = 30f;
    [SerializeField] private Text TimeText;
    [SerializeField] private GameObject GameoverPanel;
    [SerializeField] private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        TimeText.text = timeLeft.ToString("0");
        if (timeLeft < 0)
        {
            Gameover();
        }
        if(timeLeft < 10)
        {
            TimeText.color = Color.red;
            TimeText.transform.parent.GetComponent<Text>().color = Color.red;
        }
    }

    private void Gameover()
    {
        GameoverPanel.SetActive(true);
        GameoverPanel.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Score is " + ShootScript.score;
    }

    public void RestartGame()
    {
        GameoverPanel.SetActive(false);
        timeLeft = 30;
        ShootScript.score = 0;
        scoreText.text = 0 + "";
        TimeText.color = Color.red;
        TimeText.transform.parent.GetComponent<Text>().color = Color.red;
    }
}
