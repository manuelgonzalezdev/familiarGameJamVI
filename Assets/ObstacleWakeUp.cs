using UnityEngine;
using System.Collections;

public class ObstacleWakeUp : MonoBehaviour {

    public Rigidbody rb;

    void OnTriggerEnter(Collider col)
    {
        rb.WakeUp();
        Destroy(this.gameObject);
    }
}
