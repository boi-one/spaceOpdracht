using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y < -1.5)
        {
            transform.position += new Vector3(0, speed) * Time.deltaTime;
            transform.localScale -= (new Vector3(speed / 1.4f, speed) * Time.deltaTime) /3;
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x > -8.36)
        {
            transform.position -= new Vector3(speed, 0) * Time.deltaTime;   
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y > -4.3)
        {
            transform.position -= new Vector3(0, speed) * Time.deltaTime;
            transform.localScale += (new Vector3(speed / 1.4f, speed) * Time.deltaTime) /3;
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x < 8.42)
        {
            transform.position += new Vector3(speed, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {

        }
    }
}
