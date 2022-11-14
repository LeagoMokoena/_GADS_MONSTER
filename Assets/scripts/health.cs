using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int currHealth;
    public int maxHealth;
    public GameObject screen;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(currHealth <= 0)
        {
            screen.SetActive(true);
        }
    }

    public void hurt(int damage)
    {
        currHealth -= damage;

    }
}
