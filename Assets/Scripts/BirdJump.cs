using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D bird;
    public static int score = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("velo: " + bird.velocity.y);
        if (Input.GetMouseButtonDown(0))
        {
            bird.velocity = new Vector2(0, 5);
        }
        scoreText.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            score++;
            return; //so we can have our script updating in each frame.
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if((collision.gameObject.tag == "Pipe")||(collision.gameObject.tag == "Bars"))
        {
            Destroy(gameObject); //we get our bird destroyed
            SceneManager.LoadScene(0);
        }
    }
}
