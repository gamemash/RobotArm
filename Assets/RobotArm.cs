using System;
using System.Collections;
using System.Collections.Generic;
using Lib;
using UnityEngine;

public class RobotArm : MonoBehaviour {
	public GameObject baseConnector;
	public GameObject upperArm;
	public GameObject lowerArm;
	public GameObject wristRotate;
	public GameObject wristHinge;
	public GameObject grabber;
	
	private Hinge baseHinge;
	private Hinge upperArmHinge;
	private Hinge lowerArmHinge;
	private Hinge wristRotateHinge;
	private Hinge wristHingeHinge;
	private Hinge grabberHinge;
	


	public enum Hinges
	{
		Base, UpperArm, LowerArm, WristRotate, WristHinge, Grabber
	}

	// Use this for initialization
	void Start ()
	{
		baseHinge 			= new Hinge(baseConnector, Vector3.forward, new RangeInt(0, 360), 60.0f);
		upperArmHinge 		= new Hinge(upperArm, Vector3.up, new RangeInt(270, 40), 40.0f);
		lowerArmHinge 		= new Hinge(lowerArm, Vector3.up, new RangeInt(0, 360), 40.0f);
		wristRotateHinge 	= new Hinge(wristRotate, Vector3.forward, new RangeInt(0, 360), 40.0f);
		wristHingeHinge 	= new Hinge(wristHinge, Vector3.up, new RangeInt(0, 360), 40.0f);
		// grabberHinge = new Hinge(grabber, Vector3.);
	}
	
	// Update is called once per frame
	void Update ()
	{
		MoveHinge(Hinges.Base, 180);
		MoveHinge(Hinges.UpperArm, 180);
		MoveHinge(Hinges.LowerArm, 50);
	}

	public void MoveHinge(Hinges hinge, float degree)
	{
		switch (hinge)
		{
			case Hinges.Base:
				baseHinge.moveTo(degree);
				break;
			case Hinges.UpperArm:
				upperArmHinge.moveTo(degree);
				break;
			case Hinges.LowerArm:
				lowerArmHinge.moveTo(degree);
				break;
			case Hinges.WristRotate:
				wristRotateHinge.moveTo(degree);
				break;
			case Hinges.WristHinge:
				wristHingeHinge.moveTo(degree);
				break;
		}
	}


}
