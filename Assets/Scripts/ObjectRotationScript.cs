using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotationScript : MonoBehaviour
{
	public float rotateSpeed = 20f;
    public Transform Player;
    public BallThrower ballThrower;
    private void OnMouseDrag()
    {
        if (ballThrower.count <= 0)
        {
            float rotX = Input.GetAxis("Mouse X") * rotateSpeed * Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * rotateSpeed * Mathf.Deg2Rad;
            //ebug.Log(rotX +" "+ rotY);
            Player.Rotate(Vector3.up * 100, rotX);
        }
        
    }


    void Update()
	{
	
	}
	
	
}

