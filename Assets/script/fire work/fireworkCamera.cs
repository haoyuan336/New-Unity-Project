using UnityEngine;
using System.Collections;

public class fireworkCamera : MonoBehaviour {

	// Use this for initialization
	public GameObject _cubePrefab;
	public GameObject _enterPoint;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")){
			Debug.Log ("add cube");

			GameObject cube = Instantiate (_cubePrefab, _enterPoint.transform.position, _enterPoint.transform.rotation) as GameObject;
			Rigidbody rigibody = cube.GetComponent<Rigidbody> ();
			rigibody.velocity = new Vector3 (Random.Range(-2.0f,2.0f),19,Random.Range(-2.0f,2.0f));

		}
	
	}
}
