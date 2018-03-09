using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class DirectRobotController : MonoBehaviour
{

	public GameObject RobotArm;
	private RobotArm _robotArmController;
	private float _baseAngle = 0;
	private float _upperArmAngle = 0;
	private float _lowerArmAngle = 0;
	private float _wristRotateAngle = 0;
	private float _wristHingeAngle = 0;

	// Use this for initialization
	void Start ()
	{
		_robotArmController = RobotArm.GetComponent<RobotArm>();
	}
	
	// Update is called once per frame
	void Update () {
		_robotArmController.MoveHinge(global::RobotArm.Hinges.Base, _baseAngle);
		_robotArmController.MoveHinge(global::RobotArm.Hinges.UpperArm, _upperArmAngle);
		_robotArmController.MoveHinge(global::RobotArm.Hinges.LowerArm, _lowerArmAngle);
		_robotArmController.MoveHinge(global::RobotArm.Hinges.WristRotate, _wristRotateAngle);
		_robotArmController.MoveHinge(global::RobotArm.Hinges.WristHinge, _wristHingeAngle);
	}

	public void SetBaseHinge(float value)
	{
		_baseAngle = value;
	}
	
	public void SetUpperArmHinge(float value)
	{
		//270, 40
		_upperArmAngle = value / 360 * 130 + 270;
	}
	
	public void SetLowerArmHinge(float value)
	{
		_lowerArmAngle = value;
	}
	
	public void SetWristRotateHinge(float value)
	{
		_wristRotateAngle = value;
	}
	
	public void SetWristHingeHinge(float value)
	{
		_wristHingeAngle = value;
	}
	
}
