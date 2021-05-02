using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField]
    private Transform _pointA, _pointB;
    private Vector3 _target; 
    [SerializeField]
    private float _speed;
    private bool _isMovingToA = false;

    void Update()
    {
        _target = transform.position == _target ? _target == _pointA.position ? _pointB.position : _pointA.position : _target;
        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
    }
}
