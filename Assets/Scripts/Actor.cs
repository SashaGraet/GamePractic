using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Actor : MonoBehaviour
{
    [SerializeField] private UnityEvent OnActivateAction;
    [SerializeField] private UnityEvent OnDeactivateeAction;

    public void StartAction()
    {
        OnActivateAction.Invoke();
    }
    public void StopAction()
    {
        OnDeactivateeAction.Invoke(); 
    }

}
