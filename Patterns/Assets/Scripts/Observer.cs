using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer : MonoBehaviour
{
    // Start is called before the first frame update
    public abstract void OnNotify(NotificationType notificationType);
}
