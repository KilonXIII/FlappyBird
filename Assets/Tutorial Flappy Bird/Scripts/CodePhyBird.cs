using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodePhyBird : Bird
{

    new private void Start()
    {
        base.Start();

        rigidbody2D.bodyType = RigidbodyType2D.Kinematic;
        rigidbody2D.useFullKinematicContacts = true;
    }

    public float gravity = -9.8f;
    public float acceleration;
    void Update()
    {
        acceleration += gravity * Time.deltaTime;

        transform.Translate(0, acceleration, 0);


        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Time.time > 0.7f)
            {
                acceleration = forceY;

                animator.Play("Flap", 0, 0);
            }
        }
    }
}