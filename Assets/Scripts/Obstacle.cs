using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

    public Rigidbody rb;

	void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("Ball"))
        {
            rb.isKinematic = false;
            rb.AddForce(-col.impulse, ForceMode.Impulse);
        }
    }
}
