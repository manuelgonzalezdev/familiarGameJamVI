using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadScene : MonoBehaviour {

    public string levelName;

	public void LoadGameScene()
    {
        SceneManager.LoadScene(levelName);
    }
}
