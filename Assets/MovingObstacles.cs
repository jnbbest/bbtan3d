using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacles : MonoBehaviour
{
    public Transform _pointA;
    public Transform _pointB;
    public float _speed = 1f;
    Vector3 _currentTarget;
    private void FixedUpdate()
    {
        var step = _speed * Time.deltaTime;
        if (transform.position == _pointA.position)
        {
            _currentTarget = _pointB.position;

        }
        else if ( transform.position == _pointB.position)
        {
            _currentTarget = _pointA.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, _currentTarget, step);
    }

}
