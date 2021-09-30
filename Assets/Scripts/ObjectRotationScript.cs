using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotationScript : MonoBehaviour
{
    bool dragEnabled = false;
	public float rotationSpeed;
    public float minClamp;
    public float maxClamp;
    float canonFrontAngle;
	
	
	void Update()
	{
		//RotateCanonFront();
		if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
		{
			dragEnabled = false;
		}
		if (Input.GetMouseButtonDown(0)|| Input.GetMouseButtonDown(1))
		{
			dragEnabled = true;
		}
		
		if (dragEnabled)
		{
			RotateCanonFront();
			
		}
	}
	
	void RotateCanonFront()
    {
        canonFrontAngle += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;

        canonFrontAngle = Mathf.Clamp(canonFrontAngle, minClamp, maxClamp);
        transform.localRotation = Quaternion.AngleAxis(canonFrontAngle, Vector3.forward);
    }
}

