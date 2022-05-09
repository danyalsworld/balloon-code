using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bgsoundmanager : MonoBehaviour
{
    public static bgsoundmanager instance;
    public AudioSource audio;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        if(instance==null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        audio.volume = slider.value;
    }
}
