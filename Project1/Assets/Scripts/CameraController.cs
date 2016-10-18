using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject gameBall;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - gameBall.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate (){
		transform.position = gameBall.transform.position + offset;
	}
}
