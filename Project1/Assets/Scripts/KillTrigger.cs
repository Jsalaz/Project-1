using UnityEngine;
using System.Collections;

public class KillTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider other) {

		if (other.tag == "Player") {
			//Debug.Log ("Death");
			BallController.instance.Kill();
		}
	}
}
