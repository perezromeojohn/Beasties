using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // The prefab of the object to be spawned
    public GameObject prefab;

    // The box collider of the mesh
    public BoxCollider collider;

    // The minimum and maximum amount of time between each spawn
    public float minSpawnTime = 1f;
    public float maxSpawnTime = 5f;

    // The next time when the object will be spawned
    private float nextSpawnTime;

    void Start()
    {
        // Set the initial spawn time to a random value between the minimum and maximum spawn times
        nextSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    void Update()
    {
        // Check if it's time to spawn the object
        if (Time.time >= nextSpawnTime)
        {
            // Spawn the object
            SpawnObject();

            // Set the next spawn time to a random value between the minimum and maximum spawn times
            nextSpawnTime = Time.time + Random.Range(minSpawnTime, maxSpawnTime);
        }
    }

    void SpawnObject()
    {
        // Calculate a random position within the bounds of the box collider
        Vector3 position = collider.bounds.min + new Vector3(Random.Range(0f, collider.bounds.size.x), Random.Range(0f, collider.bounds.size.y), Random.Range(0f, collider.bounds.size.z));

        // Instantiate the prefab at the random position
        GameObject spawnedObject = Instantiate(prefab, position, Quaternion.identity);

        // Set the parent of the spawned object to the game object with this script attached
        spawnedObject.transform.parent = transform;
    }
}
