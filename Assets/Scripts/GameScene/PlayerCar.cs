using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : MonoBehaviour
{
    Quaternion targetRotation;
    [SerializeField] float turnSpeed = 5;
    [SerializeField] float acceleration = 8;
    Rigidbody _rigidboy;

    private void Start()
    {
        _rigidboy = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        SetRotationPoint();
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
    }
    public void SetRotationPoint()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        float distance;
        if (plane.Raycast(ray, out distance))
        {
            Vector3 target = ray.GetPoint(distance);
            Vector3 direction = target - transform.position;
            float rotationAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            targetRotation = Quaternion.Euler(0, rotationAngle, 0);
        }
    }


    private void FixedUpdate()
    {
        if(Input.GetMouseButton(0))
        {
            //this
        }
        else if(Input.GetMouseButton(1))
        {
            //this
        }

        //instead of doinf this we can use the ? symbol true:false
        //example (Input.GetMouseButton(0) ? 1:0)
        //Input.GetMouseButton(0) ? 1 : Input.GetMouseButton(1)? -1: 0

        float accelerationInput = acceleration * (Input.GetMouseButton(0) ? 1 : Input.GetMouseButton(1) ? -1 : 0) * Time.fixedTime;
        _rigidboy.AddRelativeForce(Vector3.forward * accelerationInput);
    }
}
