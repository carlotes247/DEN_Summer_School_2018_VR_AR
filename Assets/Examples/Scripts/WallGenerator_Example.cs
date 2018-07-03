using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

/// <summary>
/// Generates a wall
/// </summary>
public class WallGenerator_Example : MonoBehaviour
{
	/// <summary>
	/// Reference to the Cube prefab to instantiate
	/// </summary>
	public GameObject CubePrefab;
	/// <summary>
	/// Public variable to set the width of the wall
	/// </summary>
	public int Width = 5;
	/// <summary>
	/// Public variable to set the height of the wall
	/// </summary>
	public int Height = 5;

	/// <summary>
	/// Function to generate the wall
	/// </summary>
	void GenerateWall()
	{
		// We create a variable to offset the wall by half its width so that appears centered
		Vector3 centeringOffset = transform.right * (float)Width * -0.5f;
		// Loop through the width of the wall
		for (int x = 0; x < Width; x++)
		{
			// Loop through the height of the wall
			for (int y = 0; y < Height; y++)
			{
				// Create a new block at this current, offset by the width, height, and centering offset
				GameObject newBlock = Instantiate(CubePrefab, centeringOffset + transform.position + (transform.right * x) + (transform.up * y), transform.rotation);
				// Make the new block a child of this object to neaten the project heirarchy
				newBlock.transform.parent = this.transform;
			}
		}
	}
	
	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start () {
		// Call function to generate the wall
		GenerateWall();
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update () {
		
	}
	
}
