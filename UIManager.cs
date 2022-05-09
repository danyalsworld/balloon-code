using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public TMP_Text ScoreTxt;
    int Score;
    public bool level2or3;
 
   
    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
         
            Destroy(this.gameObject);
        }
        if (level2or3)
        {
            ScoreTxt.text = "Score : " + PlayerPrefs.GetInt("Score", 0).ToString();

        }
        else
        {
            PlayerPrefs.SetInt("Score", 0);
            ScoreTxt.text = "Score : " + PlayerPrefs.GetInt("Score", 0).ToString();
            
        }
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
    public void UpdateScore()
    {
       
        Score = PlayerPrefs.GetInt("Score", 0);
        Score++;
        ScoreTxt.text = "Score : " + Score;
        PlayerPrefs.SetInt("Score", Score);
    }

    public void UpdateScoreLess()
    {
        Score = PlayerPrefs.GetInt("Score", 0);
        Score--;
        ScoreTxt.text = "Score : " + Score;
        PlayerPrefs.SetInt("Score", Score);
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
    }
}