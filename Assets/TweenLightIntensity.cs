using UnityEngine;
using System.Collections;

public class TweenLightIntensity : MonoBehaviour {

    public Light thisLight;
    public float to = 1f;
    public float tweenDuration = 3;


    private void Start()
    {
        Hashtable tweenParams = new Hashtable();
        tweenParams.Add("from", thisLight.intensity);
        tweenParams.Add("to", to);
        tweenParams.Add("time", tweenDuration);
        tweenParams.Add("looptype", iTween.LoopType.pingPong);
        tweenParams.Add("onupdate", "OnIntensityUpdate");

        iTween.ValueTo(gameObject, tweenParams);
    }


    private void OnIntensityUpdate(float intensity)
    {
        thisLight.intensity = intensity;
    }
}
