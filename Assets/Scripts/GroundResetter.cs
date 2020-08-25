using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundResetter : MonoBehaviour
{
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
        if(collision.gameObject.tag == "Bars") {
            collision.gameObject.transform.position += (new Vector3(10.05f, 0f, 0f));
            //Debug.Log(collision.bounds.size);
        }
    }
}
