/****************** ALL RIGHTS RESERVED - SEASIA INFOTECH PVT LTD******************/

using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {


	private Transform target;
	public float speed;

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("MoveToObject").transform;
	}
	void Update() {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);

		Destroy (gameObject, 10);
	}
}
