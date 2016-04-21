using UnityEngine;
using System.Collections;

public class camearCS : MonoBehaviour {

	// Use this for initialization
	public GameObject cube;
	Rigidbody cuberigiBody;
	public GameObject towerCube;
	int addTowerSpeed;
	void Start () {
		cuberigiBody = cube.GetComponent<Rigidbody> ();
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("w")){
			if (ModelLocator.getInstace.gameState=="ready"){
				ModelLocator.getInstace.gameState="go";
			}
			cuberigiBody.velocity = Vector3.up * 6;

		}
		if (ModelLocator.getInstace.gameState=="go"){

			if (addTowerSpeed > 100) {
				float posY = Random.Range (-3, 3);
				for (var i = 0 ; i < 2 ; i++){
					float y = 0.0f;
					if (i==0){
						y = posY + 4;
					}else if (i==1){
						y = posY - 4;
					}
					Instantiate (towerCube, new Vector3 (6, y, 10), transform.rotation);
				}
				addTowerSpeed = 0;
			} else {
				addTowerSpeed++;
			}




		}
	
	}
}
