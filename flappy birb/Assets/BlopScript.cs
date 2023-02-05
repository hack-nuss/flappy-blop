using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlopScript : MonoBehaviour
{
    public Rigidbody2D MyRigidbody;
    public float flapStregth;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MyRigidbody.velocity = Vector2.up * flapStregth;
        }
        
    }
}
