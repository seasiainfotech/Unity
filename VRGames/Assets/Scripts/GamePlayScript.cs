/****************** ALL RIGHTS RESERVED - SEASIA INFOTECH PVT LTD******************/

using UnityEngine;
using System.Collections;

public class GamePlayScript : MonoBehaviour {


	public GameObject Bullet;	
	public GameObject Bullet_InstantiationPosition;

	// Use this for initialization
	void Start () {
		InvokeRepeating("LaunchBullet",0.1f, 1f);
	}
	
	// Update is called once per frame
	void LaunchBullet() {
		if (HelicopterScript.isGameOver == false) {
			Instantiate (Bullet, new Vector3 (Bullet_InstantiationPosition.transform.position.x, Bullet_InstantiationPosition.transform.position.y, Bullet_InstantiationPosition.transform.position.z), Quaternion.Euler (80, 0, 0));
		}
	}

//	void OnTriggerEnter(Collider other) 
//	{
//		Debug.Log ("collided with helicopter");
//		if (other.gameObject.tag == "Bullet") 
//		{
//			Time.timeScale = 0;
//		}
//	}
}
