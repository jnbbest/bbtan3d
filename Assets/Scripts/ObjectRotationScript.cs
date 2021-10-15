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
            //rotX = Mathf.Clamp(rotX, -26f, 26f);
            Player.Rotate(Vector3.up * 100, rotX);
            Vector3 p = Player.rotation.eulerAngles;
            //p.y = Mathf.Clamp(p.y, -26, 26);
            //Player.eulerAngles = p;
            

        }
        
    }


    void Update()
	{
	
	}
	
	
}

