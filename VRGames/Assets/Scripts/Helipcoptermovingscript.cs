/****************** ALL RIGHTS RESERVED - SEASIA INFOTECH PVT LTD******************/

using UnityEngine;
using System.Collections;

public class Helipcoptermovingscript : MonoBehaviour {

	public Transform Road;
	public GameObject RoadPrefab;

	// Use this for initialization
	void Start () {
//		Instantiate (RoadPrefab, new Vector3 (0, -4.7f, -267f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
//		float diff = transform.position.z - GameObject.Find ("Road(Clone)").transform.position.z;
//		Debug.Log("transform.position.z - GameObject.Find (\"Road(Clone)\").transform.position.z-->>"+ diff);
		transform.Translate(Vector3.forward * Time.deltaTime *10f);
//
//		if (transform.position.z - GameObject.Find ("Road(Clone)").transform.position.z >= 400f) {
//			Debug.Log ("difference Increased");
//			if (!GameObject.Find ("Road(Clone)")) {
//				GameObject Prefab_pool = Instantiate (RoadPrefab, new Vector3 (Road.transform.position.x, Road.transform.position.y, Road.transform.position.z + 200), Quaternion.identity) as GameObject;
//			}
//		}
	}
}
