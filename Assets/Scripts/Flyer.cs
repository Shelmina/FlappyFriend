using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyer : MonoBehaviour
{
    Vector3 uppoint;
    public Rigidbody2D rb;
    bool up = true;
    bool down = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= 1.2f)
        {
            down = true;
            up = false;
        }
        else if(transform.position.y <= 1.0f)
        {
            up = true;
            down = false;
        }
        if (down)
        {
            transform.Translate(new Vector3(0f,-0.002f,0f));
        }
        else if (up)
        {
            transform.Translate(new Vector3(0f, 0.002f, 0f));
        }
    }
}
