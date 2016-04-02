using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

    public Rigidbody rb;

	void Awake()
    {
        gameObject.layer = LayerMask.NameToLayer("Obstacle");
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("Ball"))
        {
            rb.isKinematic = false;
            transform.parent = null;
            rb.AddForce(-col.impulse, ForceMode.Impulse);
        }
    }
}
