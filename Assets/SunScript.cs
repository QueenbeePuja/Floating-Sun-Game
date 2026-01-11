using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    public logicforscore logic;
    public bool sunIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicforscore>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && sunIsAlive == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        sunIsAlive = false;
    }
}
