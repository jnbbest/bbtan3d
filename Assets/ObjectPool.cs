using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool main;

    //settings
    public GameObject ObjectPrefab;
    public int poolSize = 100;
    private List<Object> availableObjects;

    private void Awake()
    {
        main = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        availableObjects = new List<Object>();
        for (int i = 0; i < poolSize; i++)
        {
            Object b = Instantiate(ObjectPrefab, transform).GetComponent<Object>();
            b.gameObject.SetActive(false);

            //add it to the pool
            availableObjects.Add(b);
        }
    }

    public void PickFromPool(Vector3 position, Vector3 velocity)
    {
        //prevent errors
        if (availableObjects.Count < 1) return;

        // Activate the Object
        availableObjects[0].Activate(position, velocity);

        //pop it from the list
        availableObjects.RemoveAt(0);
    }

    public void AddtoPool(Object Object)
    {
        // add the Object (back) to the pool
        if (!availableObjects.Contains(Object)) availableObjects.Add(Object);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
