using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrower : MonoBehaviour
{
    public float m_throwForce = 10f;
    public GameObject _ball;
    bool throwEnabled = false;
    ObjectPool Opool;
    public Transform firepoint;
    public float firepower;
    // Start is called before the first frame update
    void Start()
    {
        Opool = ObjectPool.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
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
        WaitForSeconds wait = new WaitForSeconds(.1f);
        for (int i = 0; i < 4; i++)
        {
            Opool.PickFromPool(firepoint.position, objectVec);
            
            yield return wait;
        }
    }
   
    
}
