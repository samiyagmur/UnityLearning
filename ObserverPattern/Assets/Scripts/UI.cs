using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : Subject
{   
    public void BackMovementInput()
    {
        Notify(NotificationType.ForwardButton);
    }
    public void RightMovementInput()
    {
        Notify(NotificationType.BackButton);
    }
    public void LeftMovementInput()
    {
        Notify(NotificationType.RightButton);
    }
    public void ForwardMovementInput()
    {
        Notify (NotificationType.LeftButton);
    }
}
