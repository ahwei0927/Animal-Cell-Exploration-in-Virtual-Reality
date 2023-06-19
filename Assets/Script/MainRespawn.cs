using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainRespawn : MonoBehaviour
{
    public GameObject objectPrefab; // Drag and drop the object prefab in this field in the Inspector
    public float respawnTime = 5f; // Time in seconds between respawns
    public float speed = 2f; // Speed of the object
    public Transform spawnPoint; // The point where the object should spawn
    public int numObjects = 100; // Number of objects to spawn at the start of the scene
    public Vector3 objectScale = new Vector3(1f, 1f, 1f); // Scale of the spawned object

    private float timer = 0f; // Timer to keep track of respawn time

    void Start()
    {
        // Spawn the initial objects
        for (int i = 0; i < numObjects; i++)
        {
            SpawnObject();
        }
    }

    void Update()
    {
        // Increase timer
        timer += Time.deltaTime;

        // Check if it's time to respawn
        if (timer >= respawnTime)
        {
            // Reset timer
            timer = 0f;

            // Spawn a new object
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        // Instantiate a new object from the prefab
        GameObject newObject = Instantiate(objectPrefab, spawnPoint.position, Quaternion.identity);

        // Set the object's parent to this object
        newObject.transform.parent = transform;

        // Set the object's scale to the specified scale
        newObject.transform.localScale = objectScale;

        // Attach a script to the object
        if(newObject.name != "Vesicle(Clone)" && newObject.name != "GolgiVesicle(Clone)")
        {
            newObject.AddComponent<MainAutoMove>();

            newObject.AddComponent<Rigidbody>().useGravity = false;
            newObject.AddComponent<CapsuleCollider>();
        }
        
    }
}
