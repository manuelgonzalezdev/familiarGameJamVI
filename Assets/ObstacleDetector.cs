using UnityEngine;
using System.Collections;

public class ObstacleDetector : MonoBehaviour {

	void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
    }

}
