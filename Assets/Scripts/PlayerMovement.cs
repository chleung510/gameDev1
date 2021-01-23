using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float maxSpeed, jumpHeight;

    void Update() {

        // If W key(up key) is pressed
        if (Input.GetKeyDown(KeyCode.W)) {
            // TODO: Jump
            if (Physics2D.IsTouchingLayers(GetComponent<Collider2D>())) {
                // Then player is touching floor. 

                // note:
                // 1. Rigidbody2D is the player.
                // 2. Dot velocity is to move the player.
                // 3. 0 indicates that there is no affection in left or right movements when W key(up key) is pressed.
                // 4. jumpHeight is to be set later in unity platform. 
                GetComponent<Rigidbody2D>().velocity += new Vector2(0, jumpHeight);
            }
        }
         // If A key(left key) is pressed
        if (Input.GetKey(KeyCode.A)) {
            // TODO: Go LEFT 

            // note:
            // 1. Rigidbody2D is the player.
            // 2. AddForce is another funtion to move the player.
            // 3. -maxSpeed is to move left.
            // 4.0f indicates that there is no affection in verticle motion.
            // 5. maxSpeed is to be set later in unity platform. 
            // 6. ForceMode2D.Force is optional argument to make continue changes caused by mass
             GetComponent<Rigidbody2D>().AddForce(new Vector2(-maxSpeed / 4, 0f), ForceMode2D.Force);

            //GetComponent<Rigidbody2D>().velocity += new Vector2(-maxSpeed / 4, 0);
        }
        // If D key(right key) is pressed
        if (Input.GetKey(KeyCode.D)) {
            // TODO: Go right

            // note:
            // 1. Rigidbody2D is the player.
            // 2. AddForce is another funtion to move the player.
            // 3. -maxSpeed is to move .
            // 4.0f indicates that there is no affection in verticle motion.
            // 5. maxSpeed is to be set later in unity platform. 
            // 6. ForceMode2D.Force is optional argument to make continue changes caused by mass
            GetComponent<Rigidbody2D>().AddForce(new Vector2(maxSpeed / 4, 0f), ForceMode2D.Force);

           // GetComponent<Rigidbody2D>().velocity += new Vector2(maxSpeed / 4, 0);
        }
    }

    void FixedUpdate() {
        Rigidbody2D player = GetComponent<Rigidbody2D>();
        if (player.velocity.x > maxSpeed) {
            player.velocity = new Vector2(maxSpeed, player.velocity.y);
        } else if (player.velocity.x < -maxSpeed) {
            player.velocity = new Vector2(-maxSpeed, player.velocity.y);
        }
    }
}
