using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject gameOverPanel;
    public GameObject gameEndPanel;

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI objectCounterText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI endScoreText;

    public int objectsCount = 0;
    public int maxObjectsThisLevel = 0;

    public float score;

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
        Time.timeScale = 1f;
    }

    public void EndGame(){
        Time.timeScale = 0f;
        Debug.Log("Game Clear");
        gameEndPanel.SetActive(true);
        endScoreText.text = ("Score : ") + score.ToString("0.000");
        
    }

    public void GameOver(){
        Time.timeScale = 0f;
        Debug.Log("Game Over");
        gameOverPanel.SetActive(true);
    }

    public void LoadSceneIndex(int sceneIndex){
        Debug.Log("Load Scene : " + sceneIndex);
        SceneManager.LoadScene(sceneIndex);
        
    }

    public void RestartScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
