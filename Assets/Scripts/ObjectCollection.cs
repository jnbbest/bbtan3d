using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollection : MonoBehaviour
{
    public BallThrower ballThrower;
    
    public GameObject player;
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
        if(collision.gameObject.CompareTag("ball"))
        {
            collision.gameObject.GetComponent<Object>().Deactivate();
            ballThrower.count--;

            if(ballThrower.count <=0)
            {
                player.SetActive(true);
            }
            //collision.gameObject.GetComponent<BallThrower>().count;
        }
    }
}
