using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject infoPanel;

    private void Start()
    {
        infoPanel.SetActive(false);
    }

    public void OnClickPlayButton()
    {
        //LOAD GAMEPLAY
        SceneManager.LoadScene("Level_1");
    }

    public void OnClickInfoButton()
    {
        infoPanel.SetActive(true);
    }

    public void OnClickCloseInfoButton()
    {
        infoPanel.SetActive(false);
    }
}
