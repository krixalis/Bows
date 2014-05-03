using UnityEngine;
using System.Collections;

public class AimVisual : MonoBehaviour {

	Ray cameraRay;
	Plane cameraPlane;
	float dist;
	Vector3 pos;

	public Camera playerCamera;


	// Use this for initialization
	void Start () {	
		dist = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

		float Y = transform.rotation.y;
		float Z = transform.rotation.z;


		pos = Input.mousePosition;
		cameraRay = playerCamera.ScreenPointToRay (pos);
		//cameraPlane = new Plane(Camera.main.transform.forward, transform.position);

		RaycastHit hit;
		Physics.Raycast (cameraRay, out hit, 100);



		Debug.DrawLine (cameraRay.origin, hit.point);
		this.transform.LookAt (cameraRay.origin + cameraRay.direction * hit.distance);//(cameraRay.origin + cameraRay.direction * dist);
		//transform.rotation.Set(transform.rotation.x, Y, Z, transform.rotation.w);
	}
}
