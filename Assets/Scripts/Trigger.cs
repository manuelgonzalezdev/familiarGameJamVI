using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections.Generic;

public class Trigger : MonoBehaviour {

    public UnityEvent onTriggerEnter;

    void OnTriggerEnter(Collider col)
    {
        onTriggerEnter.Invoke();
        this.enabled = false;
    }






}
