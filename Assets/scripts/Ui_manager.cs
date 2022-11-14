using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ui_manager : MonoBehaviour
{
    private health He;
    private energy_detecter energy;
    public Slider bar;
    public Slider ener;
    public GameObject screen,screen2;
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
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        screen.SetActive(false);
    }

    public void exit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        
    }
}
