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

    void Start()
    {
        _target = _pointA.position;
    }

    void FixedUpdate()
    {
        _target = transform.position == _target ? _target == _pointA.position ? _pointB.position : _pointA.position : _target;
        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
    }

    // Because we're using Character controller, the Trigger must be large enough for the character controller hitbox to notice the trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.parent = transform;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.parent = null;
        }
    }
}
