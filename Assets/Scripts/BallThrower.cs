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
    public GameObject Obstacles;
    public int  obscountcompare = 3;
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
            //Debug.Log("for loop");
           GameObject temp =  Opool.PickFromPool(firepoint.position, objectVec);
            count++;
            Debug.Log("child count" + " " + Obstacles.transform.childCount);
            if(GetObstacleCount() <= obscountcompare)
            {
                temp.GetComponent<ball>().powerBall = true;
            }
           //Debug.Log(count +" "+ ballincreaser);
            yield return wait;
        }
        

        
    }
    private int GetObstacleCount()
    {
        int count = 0;
        for (int i = 0; i < Obstacles.transform.childCount; i++)
        {
            if (Obstacles.transform.GetChild(i).gameObject.activeInHierarchy)
            {
                count++;
                
            }

        }
        return count;
    }

}
