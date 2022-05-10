using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MovementStyle/MovementToDriection")]
public class MovementToDirection : MovementStyle
{
    public float speed = 5;
    public ForceMode forceMode;
    public override void Move(Movement movement, Vector3 direction)
    {
        movement.GetComponent<Rigidbody>().AddForce(direction*speed, forceMode);
    }
}
