using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.position += this.transform.forward * 0.1f;
		}
		else if (Input.GetKey (KeyCode.DownArrow)) {
			this.transform.position += this.transform.forward * -1 * 0.1f;
		}
		else if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.position += this.transform.right * 0.1f;
		}
		else if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.position += this.transform.right * -1 * 0.1f;
		}
	}
}
