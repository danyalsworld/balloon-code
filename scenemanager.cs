using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    public static scenemanager Instance;
    public int LevelBalloonscount;
    public bool Level1, Level2, Level3;
    float CurrentTime;
    float TimetoBig = 1.5f;
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
    }
    private void Update()
    {
        CurrentTime += Time.deltaTime;
        if (CurrentTime >= TimetoBig)
        {
            CurrentTime = 0f;

            UIManager.Instance.UpdateScoreLess();
        }
    }
    public void LevelOneBalloonsCount()
    {
        if (Level1)
        {


            LevelBalloonscount--;
            if (LevelBalloonscount <= 0)
            {
                //UIManager.Instance.UpdateScoreLess();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        if(Level2)
        {
            LevelBalloonscount--;
            if (LevelBalloonscount <= 0)
            {
               // UIManager.Instance.UpdateScoreLess();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        if (Level3)
        {
            LevelBalloonscount--;
            if (LevelBalloonscount <= 0)
            {
               // UIManager.Instance.UpdateScoreLess();
                saveplayerdata.instance.UpdateScore(PlayerPrefs.GetInt("Score", 0), PlayerPrefs.GetString("Name"));
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
          
          
        }
    }
  
}
