using UnityEngine;
using System.Collections;

public class fireworkCell : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	int destoryTime = Random.Range(100,200);
	int notTime = 0;
	void Update () {
		if (notTime > destoryTime){
			notTime = 0;
			Destroy (transform.gameObject);
		}
		notTime++;
	}
}
