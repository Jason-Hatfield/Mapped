using CodeMonkey.HealthSystemCM;
using UnityEngine;

public class JustForTheCapsule : MonoBehaviour
{
    public GameObject otherObject;
    public AudioSource audioSource;
    public GameObject thirdObject;
    void OnTriggerEnter()
    {
        otherObject.GetComponent<HealthSystemComponent>().GetHealthSystem().Damage(30);
        if (otherObject.GetComponent<HealthSystemComponent>().GetHealthSystem().GetHealth() <= 0)
        {
            thirdObject.GetComponent<TimerController>().EndTimer();
            Debug.Log("DON'T YOU LECTURE ME WITH YOUR THIRTY DOLLAR HAIRCUT");
            audioSource.Play();
            Application.Quit();
        }
    }
}
