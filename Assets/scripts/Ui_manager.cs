using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_manager : MonoBehaviour
{
    private health He;
    private energy_detecter energy;
    public Slider bar;
    public Slider ener;
    // Start is called before the first frame update
    void Start()
    {
        He = FindObjectOfType<health>();
        energy = FindObjectOfType<energy_detecter>();
    }

    // Update is called once per frame
    void Update()
    {

        bar.maxValue = He.maxHealth;
        bar.value = He.currHealth;
        ener.maxValue = energy.maxEnergy;
        ener.value = energy.currEnergy;

        if (energy.currEnergy <= 0)
        {
            He.currHealth -= 1;
        }
    }
}
