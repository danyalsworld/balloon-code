using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BalloonMovement : MonoBehaviour
{
    public float speed;
    public float TopX, TopY, BottomY, BottomX;
    Vector2 dirX=Vector2.left;
    Vector2 dirY=Vector2.down;
    public bool level2;
    // Start is called before the first frame update
    public float TimetoBig;
   float CurrentTime;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime += Time.deltaTime;
        if (CurrentTime >= TimetoBig)
        {
            CurrentTime = 0f;
            transform.localScale += new Vector3
                (.4f, .4f, 0);
           
        }
        {
            if(transform.localScale.x>=3.5f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        transform.Translate(dirX * speed * Time.deltaTime);

        if (transform.position.x <= -8)
        {
            dirX = Vector3.right;
        }
        else if (transform.position.x >= 8)
        {
            dirX = Vector3.left;
        }

        if (level2)
        {



            transform.Translate(dirY * speed * Time.deltaTime);

            if (transform.position.y <= 0)
            {
                dirY = Vector3.up;
            }
            else if (transform.position.y >= 4)
            {
                dirY = Vector3.down;
            }
        }
    }
}
