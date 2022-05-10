using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverManager : MonoBehaviour
{
    #region Singleton

    private static ObserverManager _instance =null;

    public static ObserverManager Instance => _instance;

    #endregion

    private List<Subject> _subjects = null;

    public void RegisterSubject(Subject subject)
    {
        if (_subjects == null)
        {
            _subjects = new List<Subject>();
        }
        _subjects.Add(subject);
    }
    private void Awake()
    {
        _instance = this;
    }
}

public enum NotificationType
{
    ForwardButton,
    BackButton,
    LeftButton,
    RightButton,
}
