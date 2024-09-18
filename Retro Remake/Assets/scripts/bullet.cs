using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float Speed = 500.0f;

    public float MaxLifetime = 10.0f;

    private Rigidbody2D _Rigidbody;

    private void Awake()
    {
        _Rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Project(Vector2 direction)
    {
        _Rigidbody.AddForce(direction * this.Speed);

        Destroy(this.gameObject, this.MaxLifetime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}

