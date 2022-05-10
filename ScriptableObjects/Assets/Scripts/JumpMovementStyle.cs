using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "MovementStyle/JumpMovementStyle")]
public class JumpMovementStyle : MovementStyle
{
    public float speed = 5;
    public float height = 3;
    public ForceMode forceMode;
    public override void Move(Movement movement, Vector3 direction)
    {
        direction *= speed;

        direction.y = height;
        movement.GetComponent<Rigidbody>().AddForce(direction, forceMode);

    }
}
