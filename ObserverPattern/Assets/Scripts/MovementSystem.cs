using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : Observer
{
    Rigidbody rigidbody;

    Vector3 direction;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        ObserverMeneger.Instance.RegisterObserver(this,SubjectType.MovementPanle);
    }
    public override void OnNotify(NotificationType notificationType)
    {
        
        switch (notificationType)
        {
            case NotificationType.ForwardButton:
                direction = Vector3.forward;
                direction.x =rigidbody.velocity.x;
                direction.y =rigidbody.velocity.y;
                break;
            case NotificationType.BackButton:
                direction.x = rigidbody.velocity.x;
                direction.y = rigidbody.velocity.y;
                direction = Vector3.back;
                break;
            case NotificationType.LeftButton:
                direction.y = rigidbody.velocity.y;
                direction.z =rigidbody.velocity.z;
                direction = Vector3.left;
                break;
            case NotificationType.RightButton:
                direction = Vector3.right;
                direction.y = rigidbody.velocity.y;
                direction.z = rigidbody.velocity.z;
                break;

            
        }
    }

    private void FixedUpdate()
    {
        Movement();
    }

    public void Movement()
    {
        Debug.Log(direction);

        rigidbody.velocity = direction*3;
    }
}
