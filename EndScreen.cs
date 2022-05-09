using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    public TMP_Text endscreen;
    // Start is called before the first frame update
    void Start()
    {
        endscreen.text ="Score : "+ PlayerPrefs.GetInt("Score", 0).ToString();
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }
}
