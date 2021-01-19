using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float MoveSpeed;
    public float RotationSpeed;

    Transform EarthTransform;

    void Awake()
    {
        EarthTransform = GameObject.Find("Earth").transform;
    }

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 directionVector = (EarthTransform.position - transform.position).normalized;
        transform.position += directionVector * MoveSpeed * Time.deltaTime;
        transform.Rotate(transform.up, RotationSpeed * Time.deltaTime);
    }
}
