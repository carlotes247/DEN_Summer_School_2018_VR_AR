using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController_Example : MonoBehaviour {

    public float TimeToLive;
    private float m_Timer;

    // Use this for initialization
    void Start () {
        // Start the internal timer with the time to live
        m_Timer = TimeToLive;
	}
	
	// Update is called once per frame
	void Update () {

        // If timer is depleted...
        if (m_Timer <= 0)
        {
            // We reset the timer
            m_Timer = TimeToLive;
            // And destroy the bullet
            Destroy(this.gameObject);
        }
        // If it is not...
        else
        {
            // Run timer down
            m_Timer -= Time.deltaTime;
        }


    }
}
