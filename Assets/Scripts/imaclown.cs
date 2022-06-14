using UnityEngine;
using CodeMonkey.HealthSystemCM;

public class imaclown : MonoBehaviour
{
	public GameObject otherObject;
    private void Update()
    {
		if (GetComponent<HealthSystemComponent>().GetHealthSystem().GetHealth() <= 0)
		{
			otherObject.GetComponent<TimerController>().EndTimer();
			transform.position = new Vector3(0f, 0f, 0f);
			GetComponent<HealthSystemComponent>().GetHealthSystem().SetHealth(100);
			otherObject.GetComponent<TimerController>().BeginTimer();
		}

    }
}
