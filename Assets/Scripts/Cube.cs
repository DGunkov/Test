using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float _move_spead;
    private Vector3 _target_position;

    void Start()
    {
        
    }

    internal float Move_spead
    {
        set
        {
            _move_spead = value;
        }
    }
    internal Vector3 Target_position
    {
        set
        {
            _target_position = value;
        }
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target_position, Time.deltaTime * _move_spead);
        if(Vector3.Distance(_target_position, transform.position) < 0.001f)
        {
            Destroy(gameObject);
        }
    }
}
