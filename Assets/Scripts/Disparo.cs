using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {

    public Energy energyUI;
    public AudioSource audioDisparo;
    public GameObject ballPrefab;
    public float pushForce = 5f;


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && energyUI.energy > 0)
        {
            Vector3 aux = Input.mousePosition;
            aux.z = 10;
            Vector3 p = Camera.main.ScreenToWorldPoint(aux);
            GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity) as GameObject;
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            rb.AddForce((p - transform.position) * pushForce, ForceMode.VelocityChange);
            energyUI.EnergyUsed();
            audioDisparo.Play();
        }
    }

}
