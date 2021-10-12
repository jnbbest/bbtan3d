using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    // Rigibody component reference
    public Rigidbody rbody;
    // Prevent the bullet from never deactivating if nothing is hit
    public float LifeTime;

    public void Activate(Vector3 position, Vector3 velocity)
    {
        // Set position and movement velocity
        transform.position = position;
        rbody.velocity = velocity;

        //Activate the GameObject
        gameObject.SetActive(true);

        // Start decay coroutine
        //StartCoroutine("Decay");

    }

    private IEnumerator Decay()
    {
        //Decay after lifetime seconds
        yield return new WaitForSeconds(LifeTime);
        Deactivate();
    }

    public void Deactivate()
    {
        //Put the bullet back into the pool
        ObjectPool.main.AddtoPool(this);

        //Stop all coroutines to prevent errors
        StopAllCoroutines();

        //Deactivate the Gameobject
        gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        //Here is where you'd put the code to handle bullet hits
        Debug.Log("Object touch kiya yaayie");

        //after hitting anything just deactivate the bullet
        Deactivate();

    }
}
