using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MembraneMoving : MonoBehaviour
{
    public float speed = 25f; // Speed of the object
    public float activeDistance = 500f; // Distance the object moves when activated
    public Vector3 startPosition; // Starting position of the object

    private Vector3 targetPosition; // Target position the object will move towards
    

    void Start()
    {
        // Set the starting position
        startPosition = transform.position;

        // Calculate the target position based on the active distance
        targetPosition = startPosition + new Vector3(0f, 0f, -activeDistance);
    }

    void Update()
    {
        // If the object is active, move towards the target position
        if (isActiveAndEnabled)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        // If the object is not active, move back the starting position
        else
        {
            transform.position = Vector3.MoveTowards(startPosition, targetPosition, speed * Time.deltaTime); ;
        }
    }

}
