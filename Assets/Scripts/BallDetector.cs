using UnityEngine;
using System.Collections;

public class BallDetector : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
    }

}
