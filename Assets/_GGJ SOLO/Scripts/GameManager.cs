using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject gameOverPanel;

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

    public void OnTimerEnd(){
        Debug.Log("Timer ended");
        gameOverPanel.SetActive(true);
    }
}
