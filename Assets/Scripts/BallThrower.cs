using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrower : MonoBehaviour
{
    
    public GameObject _ball;
    bool throwEnabled = false;
    ObjectPool Opool;
    public Transform firepoint;
    public float firepower;
    public int count;
    public int ballincreaser = 4;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Opool = ObjectPool.main;
        //count = ballincreaser;

    }

    // Update is called once per frame
    void Update()
    {
        if (count <=0 && Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1) )
        {
            throwEnabled = true;
            StartCoroutine(throwballs());
        }
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            throwEnabled = false;
            
        }
        
    }

    private IEnumerator throwballs ()
    {
        Vector3 objectVec = transform.forward * firepower;
        count = 0;
        WaitForSeconds wait = new WaitForSeconds(.1f);
        for (int i = 0; i < ballincreaser; i++)
        {
            Opool.PickFromPool(firepoint.position, objectVec);
            count++;    
            yield return wait;
        }
        ballincreaser++;

        if (count > 0)
        {
            player.SetActive(false);
        }
    }


}
