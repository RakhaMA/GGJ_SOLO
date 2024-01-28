using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject gameOverPanel;
    public GameObject gameEndPanel;

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI objectCounterText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        
    }

    public void EndGame(){
        Debug.Log("Game Clear");
        gameEndPanel.SetActive(true);
    }

    public void GameOver(){
        Debug.Log("Game Over");
        gameOverPanel.SetActive(true);
    }
}
