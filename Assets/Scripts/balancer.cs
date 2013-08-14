using UnityEngine;
using System.Collections;

public class balancer : MonoBehaviour {
	
	public OVRCameraController camController = null;
	public Rigidbody groundController = null;
	
	private Quaternion riftOrientation = Quaternion.identity;
	
	// Use this for initialization
	void Start () {
		OVRDevice.GetOrientation(0, ref riftOrientation);
	}
	
	// Update is called once per frame
	void Update () {
		OVRDevice.GetOrientation(0, ref riftOrientation);
		Debug.Log(riftOrientation);
		groundController.rotation = riftOrientation;
		
	}
}
