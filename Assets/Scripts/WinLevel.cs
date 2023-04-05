using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WinLevel : MonoBehaviour {

	public Text canvas;

	void OnTriggerEnter(Collider other) {
		canvas.enabled = true;
		GetComponent<AudioSource>().Play();
		GetComponent<MeshRenderer>().enabled = false;
		GetComponent<SphereCollider>().enabled = false;
	}
}
