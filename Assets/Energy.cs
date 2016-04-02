using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour {

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
    }

}
