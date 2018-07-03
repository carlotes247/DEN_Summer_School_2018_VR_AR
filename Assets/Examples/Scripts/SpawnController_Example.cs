using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles spawning logic
/// </summary>
public class SpawnController_Example : MonoBehaviour {

    /// <summary>
    /// Reference to the object around which the enemies will spawn
    /// </summary>
    public GameObject Origin;
    /// <summary>
    /// Reference to the Enemy prefab to be spawned
    /// </summary>
    public GameObject ObjectToSpawn;
    /// <summary>
    /// Public variable to set how wide a radius to spawn within
    /// </summary>
    public float RadiusOfSpawn;
    /// <summary>
    /// Public variable to set the time interval between spawning
    /// </summary>
    public float TimeToSpawn;
    /// <summary>
    /// Private variable to hold the count down timer 
    /// </summary>
    private float m_Timer;
    /// <summary>
    /// Private boolean to define whether a new enemy can spawn yet
    /// </summary>
    private bool m_CanSpawn;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start () {
		
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update () {
        // If the spawner is ready to spawn
        if (m_CanSpawn)
        {
            // If timer is depleted...
            if (m_Timer <= 0)
            {
                // We reset the timer
                m_Timer = TimeToSpawn;
                // And spawn an object!
                SpawnObject(Origin, ObjectToSpawn, RadiusOfSpawn);
            }
            // If it is not...
            else
            {
                // Run timer down
                m_Timer -= Time.deltaTime;
            }
        }        
	}

    /// <summary>
    /// Spawns an object given a radius, object and origin
    /// </summary>
    private void SpawnObject(GameObject origin, GameObject objToSpawn, float radius)
    {
        // Get position to spawn from origin
        Vector3 positionToSpawn = origin.transform.position;
        // Ofsset position with the radius, with a random offset
        positionToSpawn.x += Random.Range(-radius, radius);
        positionToSpawn.y += Random.Range(-radius, radius);
        positionToSpawn.z += Random.Range(-radius, radius);
        // We spawn the object in that new random position
        Instantiate(ObjectToSpawn, positionToSpawn, Quaternion.identity);
    }

    /// <summary>
    /// Starts spawning depending on the value
    /// </summary>
    public void StartSpawning(bool value)
    {
	    // Set the spawner as "ready to spawn"
        m_CanSpawn = value;
    }

}
