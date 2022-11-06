using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumppower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * jumppower;    
        }
        /*
        if(Score.score > 9)
        {
            SceneManager.LoadScene("ClearScene");
        }

        
        if(Score.deathcount > 4)
        {
            SceneManager.LoadScene("ClearScene");
        }
        */
        
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(Score.score > Score.bestScore){
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameoverScene");
    }
}
