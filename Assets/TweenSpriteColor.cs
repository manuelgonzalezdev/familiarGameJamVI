using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TweenSpriteColor : MonoBehaviour {

    public Image thisSprite;
    public Color to = Color.clear;
    public float tweenDuration = 3;


    private void Start()
    {
        Hashtable tweenParams = new Hashtable();
        tweenParams.Add("from", thisSprite.color);
        tweenParams.Add("to", to);
        tweenParams.Add("time", tweenDuration);
        tweenParams.Add("looptype", iTween.LoopType.none);
        tweenParams.Add("onupdate", "OnIntensityUpdate");

        iTween.ValueTo(gameObject, tweenParams);
    }


    private void OnIntensityUpdate(Color color)
    {
        thisSprite.color = color;
    }
}
