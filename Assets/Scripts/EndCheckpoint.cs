using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCheckpoint : MonoBehaviour
{
    public GameObject otherObject;
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<FirstPersonController>() == null)
            return;


        otherObject.GetComponent<TimerController>().EndTimer();
        Destroy(gameObject);
    }
}
