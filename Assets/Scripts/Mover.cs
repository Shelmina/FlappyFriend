using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 1.7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveObstacle();
    }
    void MoveObstacle()
    {
        transform.Translate(-speed*Time.deltaTime, 0, 0);
    }
}
