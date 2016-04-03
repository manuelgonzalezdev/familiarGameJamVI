using UnityEngine;
using System.Collections;

public class TweenColor : MonoBehaviour {

    public Renderer thisRenderer;
    public Color to = Color.clear;
    public float tweenDuration = 3;


    public void Play()
    {
        Hashtable tweenParams = new Hashtable();
        tweenParams.Add("from", thisRenderer.material.color);
        tweenParams.Add("to", to);
        tweenParams.Add("time", tweenDuration);
        tweenParams.Add("looptype", iTween.LoopType.none);
        tweenParams.Add("onupdate", "OnColorUpdate");

        iTween.ValueTo(gameObject, tweenParams);
    }


    private void OnColorUpdate(Color color)
    {
        thisRenderer.material.color = color;
    }
}
