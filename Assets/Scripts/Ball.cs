using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public float lifeTime = 4;

    void Start()
    {
        StartCoroutine("WaitAndDestroy");
    }

    IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(this.gameObject);
    }


}
