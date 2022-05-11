using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kijknaar : MonoBehaviour
{
    public GameObject bekijkt;
    public Vector3 rotatie;
    [SerializeField] private Vector3 _rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = bekijkt.transform.position.x - transform.position.x;
        float y = bekijkt.transform.position.y - transform.position.y;
        float ab = transform.position.x - x;
        float bc = transform.position.y - y;
        float a = bc / ab;
       
        print("hoi" + a);

        print(ab);
        print(bc);
        if (a <= 1.000f && a >= 0)
        {


            gameObject.transform.eulerAngles = new Vector3(0,0,-90); 
            
            
        }
        if (a >= -1.000f && a <= 0)
        {


            gameObject.transform.eulerAngles = new Vector3(0, 0, 90);


        }
        if (a <= 750 && a >= 1500)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }

        //transform.LookAt(bekijkt.transform);

    }
}
