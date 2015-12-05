using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class JoystickTracker : ITracker
{
    public JoystickTracker()
    {
        Debug.Log("KerbTrack: Initialising Joystick tracker...");
        string[] joysticks = Input.GetJoystickNames();
        Debug.Log("Joysticks available: ");
        for (int i = 0; i < joysticks.Length; i++)
        {
            Debug.Log(i + " - " + i + ": " + joysticks[i]);
        }
    }

    public void GetData(ref Vector3 rot, ref Vector3 pos)
    {

        if (KerbTrack.joyPitchAxisId != -1)
        {
            string pitchAxis = "joy" + KerbTrack.joystickId + "." + KerbTrack.joyPitchAxisId;
            rot.x = Input.GetAxis(pitchAxis) * 200;
            if (KerbTrack.joyPitchInverted)
                rot.x *= -1;
        }
        if (KerbTrack.joyYawAxisId != -1)
        {
            string yawAxis = "joy" + KerbTrack.joystickId + "." + KerbTrack.joyYawAxisId;
            rot.y = Input.GetAxis(yawAxis) * 200;
            if (KerbTrack.joyYawInverted)
                rot.y *= -1;
		}
		if (KerbTrack.joyRollAxisId != -1)
		{
			string rollAxis = "joy" + KerbTrack.joystickId + "." + KerbTrack.joyRollAxisId;
			rot.z = Input.GetAxis(rollAxis) * 200;
			if (KerbTrack.joyRollInverted)
				rot.z *= -1;
		}
		if (KerbTrack.joyUpDownAxisId != -1)
		{
			string yAxis = "joy" + KerbTrack.joystickId + "." + KerbTrack.joyUpDownAxisId;
			pos.y = Input.GetAxis(yAxis) / 2;
			if (KerbTrack.joyUpDownInverted)
				pos.y *= -1;
		}
		if (KerbTrack.joyLeftRightAxisId != -1)
		{
			string xAxis = "joy" + KerbTrack.joystickId + "." + KerbTrack.joyLeftRightAxisId;
			pos.x = Input.GetAxis(xAxis) / 2;
			if (KerbTrack.joyLeftRightInverted)
				pos.x *= -1;
		}
		if (KerbTrack.joyFwdBackAxisId != -1)
		{
			string zAxis = "joy" + KerbTrack.joystickId + "." + KerbTrack.joyFwdBackAxisId;
			pos.z = Input.GetAxis(zAxis) / 2;
			if (KerbTrack.joyFwdBackInverted)
				pos.z *= -1;
		}

        //rot.x = pitch;
        //rot.y = yaw;
    }

    public void ResetOrientation() { }
}
