using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // movement speed
    public float movementSpeed;

    // Update is called once per frame
    void Update()
    {
        // raw axis
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");

        // create movement vector
        Vector3 movement = new Vector3(horizontalAxis, 0, verticalAxis);

        // movement
        transform.Translate(movement * movementSpeed * Time.fixedDeltaTime);
    }
}
