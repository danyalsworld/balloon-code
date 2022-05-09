using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.CompareTag("Enemy"))
        {
           
           
            scenemanager.Instance.LevelOneBalloonsCount();
            UIManager.Instance.UpdateScore();
            SoundManager.Instance.PlayPopSound();
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
