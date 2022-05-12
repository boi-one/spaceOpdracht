using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatatie : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public SpriteRenderer spritie;
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            spritie.sprite = sprite1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            spritie.sprite = sprite3;
        }
        if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            spritie.sprite = sprite2;
        }
    }
}
