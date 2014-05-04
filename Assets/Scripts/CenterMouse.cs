using UnityEngine;
using System.Collections;

public class CenterMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Jump") == 1f) Screen.lockCursor = true; //Just for debug stuff right now okay don't judge me PLEASE
	}
}
