using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles spawning logic
/// </summary>
public class SpawnController_Example : MonoBehaviour {

    public GameObject Origin;
    public GameObject ObjectToSpawn;
    public float RadiusOfSpawn;
    public float TimeToSpawn;
    private float m_Timer;

    private bool m_CanSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

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
        m_CanSpawn = value;
    }

}
