using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Barrel : Enemy
{
    private new Rigidbody2D rigidbody;
    public float speed = 1f;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground")) 
        {
            rigidbody.AddForce(collision.transform.right * speed, ForceMode2D.Impulse);
        }
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);

    }

    public override void Death()
    {
        base.Death();
        rigidbody.velocity = Vector2.zero;
        Destroy(gameObject);
    }



}
