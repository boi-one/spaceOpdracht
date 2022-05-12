using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kijknaar : MonoBehaviour
{
    public GameObject bekijkt;
    public Vector3 rotatie;
    [SerializeField] private Vector3 _rotation;
    public GameObject kijkobject = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float x = bekijkt.transform.position.x - transform.position.x;
        float y = bekijkt.transform.position.y - transform.position.y;
        float ab = kijkobject.transform.position.x - x;
        float bc = kijkobject.transform.position.y - y;
        float a = bc / ab;
       
        print("hoi" + a);
        
        print(ab);
        print(bc);
        print("hoi 1 4"+ Mathf.Tan(a));
        if (a <= 0.577f && a >= -0.577f)
        {

            
            gameObject.transform.eulerAngles = new Vector3(0,0,-90); 
            
            
        }
        if (a >= -57.28996 && Mathf.Tan(a) <= -0.577)
        {
            

            gameObject.transform.eulerAngles = new Vector3(0, 0, 90);


        }
        if (a <= -57.28996 && Mathf.Tan(a) >= -0.577)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }

        //transform.LookAt(bekijkt.transform);
        */

        
        kijkobject.transform.LookAt(bekijkt.transform);
        if (kijkobject.transform.localEulerAngles.x <= 30 && kijkobject.transform.localEulerAngles.x >= -30)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
