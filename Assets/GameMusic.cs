using UnityEngine;
using System.Collections;

public class GameMusic : MonoBehaviour {

	void OnLevelWasLoaded(int level)
    {
        if (level == 3 || level == 4)
        {
            Destroy(this.gameObject);
        }
    }
}
