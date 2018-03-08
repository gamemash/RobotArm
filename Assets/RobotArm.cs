using System.Collections;
using System.Collections.Generic;
using Lib;
using UnityEngine;

public class RobotArm : MonoBehaviour {
	public GameObject baseConnector;
	private Hinge baseHinge;
	public GameObject upperArm;
	private Hinge upperArmHinge;
	public GameObject lowerArm;
	private Hinge lowerArmHinge;
	public GameObject wristRotate;
	public GameObject wristHinge;
	public GameObject grabber;

	// Use this for initialization
	void Start ()
	{
		baseHinge = new Hinge(baseConnector, Vector3.forward, new RangeInt(0, 360), 40.0f);
		upperArmHinge = new Hinge(upperArm, Vector3.up, new RangeInt(-110, 40), 40.0f);
		lowerArmHinge = new Hinge(lowerArm, Vector3.up, new RangeInt(0, 360), 40.0f);
	}
	
	// Update is called once per frame
	void Update ()
	{
		baseHinge.moveTo(60);
		upperArmHinge.moveTo(40);
		lowerArmHinge.moveTo(180);
		// upperArm.transform.Rotate(Vector3.down, 0.02f);
	}
}
