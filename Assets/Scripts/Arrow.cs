using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _speed;

    private void FixedUpdate()
    {
        ArrowMovement();
    }

    void ArrowMovement()
    {
        _rb.velocity = Vector2.right * _speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "monster")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
