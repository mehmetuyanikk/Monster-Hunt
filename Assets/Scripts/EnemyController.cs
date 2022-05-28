using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float _enemySpeed;

    Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        EnemyMove();
    }

    void EnemyMove()
    {
        _rb.velocity = Vector2.left * Time.deltaTime * _enemySpeed;
    }

}
