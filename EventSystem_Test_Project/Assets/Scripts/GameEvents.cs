using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;
    private void Awake()
    {
        current = this;
    }

    public event Action onDoorwayTriggerEnter;
    public void DoorWayTriggerEnter()
    {
        if (onDoorwayTriggerEnter != null)
        {
            onDoorwayTriggerEnter();
            Debug.Log("2");
        }
    }

    public event Action onDoorwayTriggerExit;
    public void DoorWayTriggerExit()
    {
        if(onDoorwayTriggerExit!=null)
        {
            onDoorwayTriggerExit();
        }
    }
}
