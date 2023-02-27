using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class InputSystem : MonoBehaviour
{
    [System.Serializable]
    public struct InputActions
    {
        public string actionName; 
        public KeyCode keyCode;
        public UnityEvent action;
        public bool isConstant;
    }

    public Animator animator;
    public List<InputActions> inputActions;

    private void Update()
    {
        foreach(InputActions action in inputActions)
        {
            if(Input.GetKeyDown(action.keyCode) || Input.GetKey(action.keyCode) && action.isConstant)
            {
                action.action.Invoke();
             
            }
        }
        if (!Input.anyKey)
        {
            animator.SetBool("RunningLeft", false);
            animator.SetBool("RunningRight", false);
        }
    }
}
