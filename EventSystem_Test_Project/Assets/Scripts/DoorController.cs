using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private float speed = 2;
    
    private void Start()
    {
        GameEvents.current.onDoorwayTriggerEnter += OnDoorWayOpen;
        GameEvents.current.onDoorwayTriggerExit += OnDoorWayClose;
    }

    private void OnDoorWayOpen()
    {
       
        LeanTween.move(gameObject, new Vector3(0.01f, 5, 0.8678741f), speed);
        Debug.Log("3");
    }

    private void OnDoorWayClose()
    {

        LeanTween.move(gameObject,new Vector3(0.01f,2, 0.8678741f), speed);
        Debug.Log("4");
    }
}
