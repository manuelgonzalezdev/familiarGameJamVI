using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour {

    public Energy energy;
    public Transform playerCamera;
    float damageDelay = 1f;
    float shakeDelay = 0.4f;
    float timeStamp;

    void Awake()
    {
        timeStamp = Time.time;
    }

	void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("Obstacle"))
        {
            float aux = Time.time - timeStamp;
            if (aux >= damageDelay)
            {
                timeStamp = Time.time;
                energy.PlayerDamaged();
                damaged = true;
                damageStamp = timeStamp;
                originalPos = playerCamera.position;
            }
        }

    }
    bool damaged;
    Vector3 originalPos;
    float damageStamp;

    void LateUpdate()
    {
        if (damaged)
        {
            if (Time.time - damageStamp >= shakeDelay)
            {
                damaged = false;
                playerCamera.position = new Vector3(originalPos.x, originalPos.y, playerCamera.position.z);
            }
            else
            {
                playerCamera.position = new Vector3(originalPos.x + Random.insideUnitCircle.x, originalPos.y + Random.insideUnitCircle.y, playerCamera.position.z);
            }
        }
    }


}
