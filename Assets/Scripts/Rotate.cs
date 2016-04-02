using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

    public Vector3 direction;
    public float speed;

    void Update()
    {
        transform.Rotate(direction, 100f * speed * Time.deltaTime);
    }

}
