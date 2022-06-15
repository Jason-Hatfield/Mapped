using StarterAssets;
using UnityEngine;

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
