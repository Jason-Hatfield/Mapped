using UnityEngine;

public class JustForTheCapsule : MonoBehaviour{
    private void OnCollisionEnter(Collision collision)
    {
        if (transform.position.y <= 5)
            Debug.Log("AAAAAAAA");
    }
}
