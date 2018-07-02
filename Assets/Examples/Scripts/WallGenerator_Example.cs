using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class WallGenerator_Example : MonoBehaviour
{

	public GameObject CubePrefab;
	public int Width = 5;
	public int Height = 5;
	public List<GameObject> Blocks = new List<GameObject>();

	// Use this for initialization
	void Start () {
		GenerateWall();
	}

	void GenerateWall()
	{
		Vector3 widthOffset = transform.right * (float)Width * -0.5f;
		for (int x = 0; x < Width; x++)
		{
			for (int y = 0; y < Height; y++)
			{
				GameObject newBlock = Instantiate(CubePrefab, widthOffset + transform.position + (transform.right * x) + (transform.up * y),
					transform.rotation);
				newBlock.transform.parent = this.transform;
				Blocks.Add(newBlock);
			}
		}

		/*foreach (var block in Blocks)
		{
			block.GetComponent<Collider>().enabled = true;
		}*/
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
