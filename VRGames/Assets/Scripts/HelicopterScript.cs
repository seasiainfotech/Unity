/****************** ALL RIGHTS RESERVED - SEASIA INFOTECH PVT LTD******************/

using UnityEngine;
using System.Collections;

public class HelicopterScript : MonoBehaviour {


	public static bool isGameOver;
	public GameObject BoomExplosion;
	// Use this for initialization
	void Start () {
		isGameOver = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) 
	{
		Debug.Log ("collided with helicopter");
		if (other.gameObject.tag == "Bullet") 
		{
//			Time.timeScale = 0;
			gameObject.GetComponent<AudioSource> ().Stop ();
			isGameOver = true;
			gameObject.GetComponent<Rigidbody>().useGravity = true;
			gameObject.transform.rotation = Quaternion.AngleAxis(-30, Vector3.left);
			StartCoroutine("waitsometime");
			GameObject BoomParticle = Instantiate(BoomExplosion,new Vector3(transform.position.x,transform.position.y,transform.position.z),Quaternion.identity )as GameObject;
			BoomParticle.transform.parent = gameObject.transform;
		}
		if (other.gameObject.tag == "TerrainCells") 
		{
			//			Time.timeScale = 0;
			gameObject.GetComponent<AudioSource> ().Stop ();
			isGameOver = true;
			gameObject.GetComponent<Rigidbody>().useGravity = true;
			gameObject.transform.rotation = Quaternion.AngleAxis(-30, Vector3.left);
			StartCoroutine("waitsometime");
			GameObject BoomParticle = Instantiate(BoomExplosion,new Vector3(transform.position.x,transform.position.y,transform.position.z),Quaternion.identity )as GameObject;
			BoomParticle.transform.parent = gameObject.transform;
		}
	}

	IEnumerator waitsometime() {
		Debug.Log("Before Waiting 2 seconds");
		yield return new WaitForSeconds(2);
		Debug.Log("After Waiting 2 Seconds");
		Application.LoadLevel ("VRGamePlay");
	}
}
