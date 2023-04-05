using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

	public float speed = 0.5f;
	public float maxY = 10f;
	private int direction = 1;
	private float initialY;


	// Use this for initialization
	void Start () {
		initialY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		float currentY = transform.position.y;

		//Move up while direction is up and below max Y
		if (direction == 1 && currentY > maxY) {
			direction = -1;
		} else if (direction == -1 && currentY < initialY) {
			direction = 1;
		}

		transform.Translate(new Vector3(0, direction * speed * Time.deltaTime, 0), Space.World);
	}
}
