// Amtoj Uppal - 100656592
// Katie Tong - 100655511

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

	public static float launchTimer = 2.0f;
	public static float xspeed = 8.0f;
	public static float zspeed = -8.0f;

	public static bool collflag = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		launchTimer -= Time.deltaTime;

		if (launchTimer <= 0)
		{
			transform.Translate(new Vector3(xspeed, 0, zspeed) * Time.deltaTime);
			launchTimer = 0.0f;
		}
	}
}
