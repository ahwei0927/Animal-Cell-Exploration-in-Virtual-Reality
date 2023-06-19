using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MitoRespawnAndMove : MonoBehaviour
{
    public GameObject objectPrefab; // Drag and drop the object prefab in this field in the Inspector
    public float respawnTime = 5f; // Time in seconds between respawns
    public float speed = 2f; // Speed of the object

    private float timer = 0f; // Timer to keep track of respawn time

    void Update()
    {
        // Increase timer
        timer += Time.deltaTime;

        // Check if it's time to respawn
        if (timer >= respawnTime)
        {
            // Reset timer
            timer = 0f;

            // Instantiate a new object from the prefab
            GameObject newObject = Instantiate(objectPrefab, transform.position, Quaternion.identity);

            // Set the object's parent to this object
            newObject.transform.parent = transform;

            // Set the object's scale to half of the original scale
            newObject.transform.localScale = objectPrefab.transform.localScale / 2f;
        }

        // Move all child objects to the right
        foreach (Transform child in transform)
        {
            child.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

}
