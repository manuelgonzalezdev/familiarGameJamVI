using UnityEngine;
using System.Collections;

public class LinearMovement : MonoBehaviour {

    public float distance = 1;
    public float speed = 0.1f;
    public Vector3 direction = Vector3.left;
    public bool pingPong = false;
    public bool startOn;
    bool running;

    float distanceMoved;

    void Start()
    {
        if (startOn)
        {
            running = true;
        }
    }

    public void Play()
    {
        running = true;
    }

    public void Stop()
    {
        running = false;
    }

	void Update()
    {
        if (running)
        {
            if (distanceMoved < distance)
            {
                float aux = distance * speed * Time.deltaTime;
                transform.position = transform.position + (direction * aux);
                distanceMoved += aux;
            }
            else if (pingPong)
            {
                distanceMoved = 0;
                direction = -direction;
            }
            else
            {
                this.enabled = false;
            }
        }
        
    }
}
