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
            gameObject.layer = LayerMask.NameToLayer("ObstacleDestroyed");
            rb.AddForce(-col.impulse, ForceMode.Impulse);
            StartCoroutine("WaitAndDestroy");
        }
    }

    IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSeconds(8f);
        Destroy(gameObject);
    }
}
