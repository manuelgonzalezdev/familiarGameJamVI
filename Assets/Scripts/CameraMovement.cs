using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    public float speed  = 5f;

    void Update()
    {
        transform.position = transform.position + (Vector3.forward * speed * Time.deltaTime);
    }

}
