using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	void Awake()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.Sleep();
    }
}
