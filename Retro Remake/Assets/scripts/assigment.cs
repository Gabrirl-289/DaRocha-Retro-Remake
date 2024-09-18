using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public KeyCode left = KeyCode.A, right = KeyCode.D, up = KeyCode.W, down = KeyCode.S, Jump = KeyCode.Space;
    public float speed = 10, jumpHeight = 15;

    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        //_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetKey(); is for HOLDING a key
        //Input.GetKeyDown(); is for PRESSING a key
        //Input.GetKeyUp(); is for RELEASING a key

        if (Input.GetKey(left)) //chek for the player holding down the left button
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed; //get the component to the ri
        }

        if (Input.GetKey(right)) // check to be holding down the right button
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;}

        if (Input.GetKey(up)) //chek for the player holding down the up button
        {
            GetComponent<Rigidbody>().velocity = Vector2.up * speed;
        }

        if (Input.GetKey(down)) //chek for the player holding down the up down button
        {
            GetComponent<Rigidbody>().velocity = Vector2.down * speed;
        }

        if (Input.GetKeyDown(Jump))
        {
            GetComponent<Rigidbody2D>() .velocity = Vector2.up * jumpHeight;
        }
        
       // if (Input.GetKeyDown(KeyCode.Y))
        //{
          // GetComponent<Rigidbody2D>() .Gravity Scale *= -1; 
        //}
    }
}
