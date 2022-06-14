using CodeMonkey.HealthSystemCM;
using UnityEngine;

public class JustForTheCapsule : MonoBehaviour{
    public GameObject otherObject;
    void OnTriggerEnter()
    {
        otherObject.GetComponent<HealthSystemComponent>().GetHealthSystem().Damage(30);
    }
}
