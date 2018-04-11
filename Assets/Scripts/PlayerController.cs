using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	void Start () {

	}

	void Update () {
		if (Input.anyKey)
			Debug.Log ("We have input!");
	}
}
