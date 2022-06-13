using UnityEngine;
using CodeMonkey.HealthSystemCM;

public class imaclown : MonoBehaviour
{
	private HealthSystem healthSystem;
	public GameObject otherObject;

    private void Awake()
    {
		healthSystem = new HealthSystem(100);
    }

    public HealthSystem GetHealthSystem()
	{
		return healthSystem;
	}

	public void Damage(float damageAmount)
	{
		healthSystem.Damage(damageAmount);
	}

	private void HealthSystem_OnDead(object sender, System.EventArgs e)
	{
		otherObject.GetComponent<TimerController>().EndTimer();
		transform.position = new Vector3(0f, 0f, 0f);
		otherObject.GetComponent<TimerController>().BeginTimer();
	}

}
