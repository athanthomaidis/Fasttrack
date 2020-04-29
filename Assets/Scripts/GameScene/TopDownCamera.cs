using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    [SerializeField] Transform observable;
    [SerializeField] float aheadSpeed;
    [SerializeField] float followDumping;
    [SerializeField] float cameraHeight;

    Rigidbody _observableRigidBody;


    private void Start()
    {
        _observableRigidBody = observable.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (observable == null)
            return;

        Vector3 targetPosition = observable.position + Vector3.up * cameraHeight + _observableRigidBody.velocity * aheadSpeed;
        transform.position = Vector3.Lerp(transform.position, targetPosition, followDumping * Time.deltaTime);
    }
}
