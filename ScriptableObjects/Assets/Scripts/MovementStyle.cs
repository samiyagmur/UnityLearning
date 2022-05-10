using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovementStyle : ScriptableObject
{
    public abstract void Move(Movement movement,Vector3 direction);
}
