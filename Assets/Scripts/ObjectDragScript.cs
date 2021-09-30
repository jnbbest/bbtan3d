using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDragScript : MonoBehaviour
{
    bool dragEnabled = false;
	Vector3 dragStartPosition;
	float dragStartDistance;
	float timer;
	public float currentSpeed;
	
	
	void Update()
	{
		if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
		{
			dragEnabled = false;
		}
		if (Input.GetMouseButtonDown(0)|| Input.GetMouseButtonDown(1))
		{
			dragEnabled = true;
			dragStartPosition = transform.position;
			dragStartDistance = (Camera.main.transform.position - transform.position).magnitude;
			timer = 0;
		}
	}
	void OnMouseDrag()
	{
		if (dragEnabled)
		{
			
			Vector3 worldDragTo = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, dragStartDistance));
			worldDragTo.x = Mathf.Clamp(worldDragTo.x, -12, 12);
			timer += Time.deltaTime;
            currentSpeed = Mathf.Lerp(0.1f, 0.13f, timer);
			
			Vector3 temp = new Vector3(worldDragTo.x, dragStartPosition.y, dragStartPosition.z);
			transform.position = Vector3.Lerp(transform.position, temp,currentSpeed);
			
		}
	}
}

