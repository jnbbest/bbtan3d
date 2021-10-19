using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            if (contact.otherCollider.CompareTag("ball"))
            {
                LevelManager.instance.ballthrower.ballincreaser++;
                
                
                    DestroyMe();
               
            }
        }
    }

    void DestroyMe()
    {
        gameObject.SetActive(false);
    }
}
