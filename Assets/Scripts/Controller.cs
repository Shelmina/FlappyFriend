
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Controller : MonoBehaviour
{
    public GameObject obs;
    float yPosition = 0;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        yPosition = Random.Range(75, 420);
        if (collision.gameObject.tag == "Obstacle")
        {
            float selectedY = yPosition / 100;
            collision.gameObject.transform.position = new Vector3(9f, selectedY, 0f);
            //Debug.Log("ok");  
        }
        //Destroy(collision.gameObject);
    }



}
