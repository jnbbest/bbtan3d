using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollider : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform ballprefab;

    void Start()
    {
       //Transform ballP = Instantiate(ballprefab) as Transform;
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Physics.IgnoreCollision(ballprefab.GetComponent<Collider>(), GetComponent<Collider>());
    }
}
