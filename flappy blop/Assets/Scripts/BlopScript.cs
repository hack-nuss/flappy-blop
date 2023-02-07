using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlopScript : MonoBehaviour
{
    public Rigidbody2D MyRigidbody;
    public float flapStregth;
    public LogicScript logic;
    public bool birdIsAlive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            MyRigidbody.velocity = Vector2.up * flapStregth;
        }

        if (Input.GetButtonDown("Fire1") && birdIsAlive)
        {
            Debug.Log(Input.mousePosition);
            MyRigidbody.velocity = Vector2.up * flapStregth;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
