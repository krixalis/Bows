using UnityEngine;
using System.Collections;

public class StickArrow : MonoBehaviour {

	public Rigidbody rbody;

	void OnCollisionEnter(Collision col)
	{
		rbody.freezeRotation = true;
		rbody.isKinematic = true;
	}
}
