using UnityEngine;
using System.Collections;

public class towerCS : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3 ( 0.06f, 0, 0);
		if (transform.position.x < -5){
			Destroy(transform.gameObject);
		}
	
	}
}
