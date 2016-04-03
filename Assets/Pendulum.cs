using UnityEngine;
using System.Collections;

public class Pendulum : MonoBehaviour {

    public Vector3 direction;
    public float angles = 30f;
    public float speed = 1f;
    public bool autoRun;
    bool running;
    public float delay;
    Vector3 originalRot;

    void Start()
    {
        originalRot = transform.eulerAngles;
        if (autoRun)
        {
            StartCoroutine("WaitAndPlay");
        }
    }

    IEnumerator WaitAndPlay()
    {
        yield return new WaitForSeconds(delay);
        Play();
    }

    public void Play()
    {
        running = true;
    }

	void Update()
    {
        if (running)
        {
            transform.Rotate(direction, speed * Time.deltaTime);
            float diff = Mathf.Abs(transform.eulerAngles.x - originalRot.x);
            if (diff > angles * 0.5f)
            {
                direction = -direction;
            }
        }
    }
}
