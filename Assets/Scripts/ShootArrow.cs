using UnityEngine;
using System.Collections;

public class ShootArrow : MonoBehaviour {

	float speed = 5.0f;
	float rotateSpeed = 3.0f;
	public Transform arrow;
	public Transform arrowOnBow;
	Transform arrowInstance;

	// Use this for initialization
	void Start () {
		arrowInstance = null;
	}
	
	// Update is called once per frame
	void Update () {
		//CharacterController ctrler = GetComponent(
		Vector3 thisPos = transform.position;
		if(Input.GetAxis ("Fire1") == 1f)
	    {
			 arrowInstance = Instantiate (arrow, arrowOnBow.transform.position, arrowOnBow.transform.rotation) as Transform;
			if(arrowInstance != null) arrowInstance.rigidbody.useGravity = true;
		}
		if (arrowInstance != null)
						arrowInstance.rigidbody.AddRelativeForce (arrow.transform.forward * 3000f);//(arrowOnBow.transform.forward * 4000);
	}
}


/*
var speed = 5.0;
var rotateSpeed = 3.0;
var bullitPrefab:Transform;

function Update ()
{
	var controller : CharacterController = GetComponent(CharacterController);
	transform.Rotate(0, Input.GetAxis ("Horizontal") * rotateSpeed, 0);
	var forward = transform.TransformDirection(Vector3.forward);
	var curSpeed = speed * Input.GetAxis ("Vertical");
	controller.SimpleMove(forward * curSpeed);
	
	if(Input.GetButtonDown("Jump"))
	{
		var bullit = Instantiate(bullitPrefab, GameObject.Find("spawnPoint").transform.position, Quaternion.identity);
		bullit.rigidbody.AddRelativeForce(transform.forwar d * 4000);
	}
	
	
}
*/