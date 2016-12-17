/****************** ALL RIGHTS RESERVED - SEASIA INFOTECH PVT LTD******************/

using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	float LevelLoadingCount;
	int countervalue;
	bool isGazeOn;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (isGazeOn) {
			countervalue = (int)(Time.time - LevelLoadingCount);
			if (countervalue == 3) {
				Application.LoadLevel ("VRGamePlay");
			}
		}

		Debug.Log (countervalue);

	}
	public void SetGazedAt(bool gazedAt) {
		isGazeOn = true;
		LevelLoadingCount = Time.time;

	}
	public void GazeExit(bool gazedAt) {
		isGazeOn = false;
		countervalue = 0;
	}
	void waitforlevel()
	{
		
	}
}
