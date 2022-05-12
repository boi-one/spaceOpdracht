using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zwartwoorden : MonoBehaviour
{
    public Image imagie;
    public float A = 0;
    public bool AmagGaan = false;
    public float snelheid = 1;
    // Start is called before the first frame update
    void Start()
    {
        imagie = GetComponent<Image>()
;    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            AmagGaan = true;
        }
        if (A >= 1.1f)
        {
            AmagGaan = false;
        }
        if (AmagGaan == true)
        {
            imagie.color = new Vector4(0,0,0,A);
            A += 0.5f * Time.deltaTime / snelheid;
        }
        if (AmagGaan == false)
        {
            imagie.color = new Vector4(0, 0, 0, A);
            if (A >= 0)
            {
                A -= 0.5f * Time.deltaTime / snelheid;
            }
            
        }


    }
}
