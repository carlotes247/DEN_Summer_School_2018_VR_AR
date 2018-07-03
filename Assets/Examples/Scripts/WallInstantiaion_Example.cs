using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallInstantiaion_Example : MonoBehaviour {

    public GameObject Wall;
    private GameObject m_InternalWall;

	// Use this for initialization
	void Start () {
        Wall.SetActive(false);
	}

    private void OnEnable()
    {
        Wall.SetActive(false);
        m_InternalWall = Instantiate(Wall);
        m_InternalWall.transform.parent = this.transform;
        m_InternalWall.SetActive(true);
    }

    private void OnDisable()
    {
        Destroy(m_InternalWall);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
