using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainAutoMove : MonoBehaviour
{
    Rigidbody rb;
    Vector3 direction;
    public float speed = 5;
    public float rotationSpeed = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }

    void Update()
    {
        // Move the object
        rb.MovePosition(transform.position + direction * speed * Time.deltaTime);

        // Rotate the object around its own axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Reflect the direction upon collision
        direction = Vector3.Reflect(direction, collision.contacts[0].normal);
    }
}
