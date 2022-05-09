using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class saveplayerdata : MonoBehaviour
{
    public TMP_Text s1,s2,s3,s4,s5;
    public TMP_Text n1,n2,n3,n4,n5;
    public int S1, S2, S3, S4, S5;
    public static saveplayerdata instance;
    public bool inLevel;

    public TMP_InputField nameinput;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        if (inLevel==false)
        {
            s1.text = PlayerPrefs.GetInt("S1", 0).ToString();
            s2.text = PlayerPrefs.GetInt("S2", 0).ToString();
            s3.text = PlayerPrefs.GetInt("S3", 0).ToString();
            s4.text = PlayerPrefs.GetInt("S4", 0).ToString();
            s5.text = PlayerPrefs.GetInt("S5", 0).ToString();



            n1.text = PlayerPrefs.GetString("n1").ToString();
            n2.text = PlayerPrefs.GetString("n2").ToString();
            n3.text = PlayerPrefs.GetString("n3").ToString();
            n4.text = PlayerPrefs.GetString("n4").ToString();
            n5.text = PlayerPrefs.GetString("n5").ToString();


            S1 = PlayerPrefs.GetInt("S1", 0);
            S2 = PlayerPrefs.GetInt("S2", 0);
            S3 = PlayerPrefs.GetInt("S3", 0);
            S4 = PlayerPrefs.GetInt("S4", 0);
            S5 = PlayerPrefs.GetInt("S5", 0);
        }
    }

    public void UpdateScore(int score,string name)
    {
        if (inLevel)
        {
            if (score > S1)
            {


                PlayerPrefs.SetInt("S1", score);
                PlayerPrefs.SetString("n1",name);


            }
            else if (score > S2)
            {
                PlayerPrefs.SetInt("S2", score);
                PlayerPrefs.SetString("n2", name);
            }
            else if (score > S3)
            {
                PlayerPrefs.SetInt("S3", score);
                PlayerPrefs.SetString("n3", name);

            }
            else if (score > S4)
            {
                PlayerPrefs.SetInt("S4", score);
                PlayerPrefs.SetString("n4", name);

            }
            else
            {
                PlayerPrefs.SetInt("S5", score);

                PlayerPrefs.SetString("n5", name);
            }
        }
        else
        {


            if (PlayerPrefs.GetInt("Score", 0) > S1)
            {


                PlayerPrefs.SetInt("S1", score);
                PlayerPrefs.SetString("n1", name);
                s1.text = PlayerPrefs.GetInt("S1", 0).ToString();

                n1.text = PlayerPrefs.GetString("n1").ToString();

            }
            else if (PlayerPrefs.GetInt("Score", 0) > S2)
            {
                PlayerPrefs.SetInt("S2", score);
                PlayerPrefs.SetString("n2", name);
                s2.text = PlayerPrefs.GetInt("S2", 0).ToString();
                n2.text = PlayerPrefs.GetString("n2").ToString();

            }
            else if (PlayerPrefs.GetInt("Score", 0) > S3)
            {
                PlayerPrefs.SetInt("S3", score);
                PlayerPrefs.SetString("n3", name);
                s3.text = PlayerPrefs.GetInt("S3", 0).ToString();
                n1.text = PlayerPrefs.GetString("n3").ToString();

            }
            else if (PlayerPrefs.GetInt("Score", 0) > S4)
            {
                PlayerPrefs.SetInt("S4", score);
                PlayerPrefs.SetString("n4", name);
                s4.text = PlayerPrefs.GetInt("S4", 0).ToString();
                n4.text = PlayerPrefs.GetString("n4");

            }
            else
            {
                PlayerPrefs.SetInt("S5", score);
                PlayerPrefs.SetString("n5", name);
                s5.text = PlayerPrefs.GetInt("S5", 0).ToString();
                n5.text = PlayerPrefs.GetString("n5");

            }
        }
    }


    public void SavePlayerName()
    {
        PlayerPrefs.SetString("Name", nameinput.text);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
