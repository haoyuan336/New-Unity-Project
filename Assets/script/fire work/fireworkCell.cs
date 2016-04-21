using UnityEngine;
using System.Collections;

public class fireworkCell : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	int notTime = 0;
	void Update () {
		if (notTime > 500){
			notTime = 0;
			Destroy (transform.gameObject);
		}
		notTime++;
	}
}
