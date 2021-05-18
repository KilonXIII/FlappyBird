using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    new public Rigidbody2D rigidbody2D;
    public Animator animator;

    public void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public float forceY = 100;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Time.time < 0.7f)
            {
                Vector2 force;
                force.x = 0;
                force.y = forceY;
                rigidbody2D.velocity = Vector2.zero;
                rigidbody2D.AddForce(force);

                animator.Play("Flap", 0, 0);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnDie(collision);
    }


    protected void OnDie(Collision2D collision)
    {
        Debug.LogWarning(collision);


        GameManager.instace.SetGameOver();

        animator.Play("Die", 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instace.AddScore();
    }
}
