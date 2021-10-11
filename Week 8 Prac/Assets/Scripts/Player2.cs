using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    // movement speed
    public float movementSpeed;

    // Update is called once per frame
    void Update()
    {
        // raw axis
        float verticalAxis = Input.GetAxisRaw("Vertical_Player2");
        float horizontalAxis = Input.GetAxisRaw("Horizontal_Player2");

        // create movement vector
        Vector3 movement = new Vector3(horizontalAxis, 0, verticalAxis);

        // movement
        transform.Translate(movement * movementSpeed * Time.fixedDeltaTime);
    }
}
