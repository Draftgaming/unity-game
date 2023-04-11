using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public float speed = 80.0f; // Code for how fast the ball can move. Also it will be public so we can change it inside of Unity itself. 
    public Rigidbody2D Player; //Player 1 Rigidbody
   


    //Player 1 Code with aswd keys
    void Player1Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Player.AddForce(Vector3.left * speed);

        }

        if (Input.GetKey(KeyCode.D))
        {
            Player.AddForce(Vector3.right * speed);

        }

        if (Input.GetKey(KeyCode.W))
        {
            Player.AddForce(Vector3.forward * speed);

        }

        if (Input.GetKey(KeyCode.S))
        {
            Player.AddForce(Vector3.back * speed);

        }
    }

    
    // Update is called once per frame
    void Update()
    {
        Player1Movement();
       
    }
}