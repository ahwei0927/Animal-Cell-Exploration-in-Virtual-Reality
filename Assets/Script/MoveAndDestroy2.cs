using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveAndDestroy2 : MonoBehaviour
{
    public Transform target; // The target point to move towards

    public float speed = 5f; // The movement speed

    private void Awake()
    {
        target = GameObject.Find("point5").transform;
    }
    private void Update()
    {
        if (target)
        {
            // Calculate the direction towards the target
            Vector3 direction = (target.position - transform.position).normalized;

            // Calculate the distance to the target
            float distance = Vector3.Distance(transform.position, target.position);

            // Move towards the target
            transform.Translate(direction * speed * Time.deltaTime);

            // Check for collision with other objects
            if (distance <= 0.5f)
            {
                // Destroy the game object
                Destroy(gameObject);
            }
        }

    }
}
