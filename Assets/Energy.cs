using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour {

    public LoadScene gameOverLoader;
    public Text energyText;
    public int energy = 100;

    void Start()
    {
        energyText.text = energy.ToString();
    }

    public void EnergyUsed()
    {
        energy = Mathf.Max(energy - 1, 0);
        energyText.text = energy.ToString();
        if (energy < 15)
        {
            energyText.color = Color.red;
        }
        else if (energy == 0)
        {
            GameOver();
        }
        else
        {
            energyText.color = Color.white;
        }
    }

    public void PlayerDamaged()
    {
        energy = Mathf.Max(energy - 10, 0);
        energyText.text = energy.ToString();
        if (energy == 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        gameOverLoader.LoadGameScene();
    }

}
