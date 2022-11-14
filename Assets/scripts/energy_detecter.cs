using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class energy_detecter : MonoBehaviour
{
    public float time = 5f;
    public float time3 = 8f;
    public int currEnergy;
    public int maxEnergy;
    public GameObject shield;
    public bool _shiled = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _shiled = true;
            shield.SetActive(true);
   
        }

        time3 -= Time.deltaTime;
        if (time3 <= 0)
        {
            currEnergy -= 10;
            shield.SetActive(false);
            time3 = 8f;
            _shiled = false;
        }

        time -= Time.deltaTime;
        if(time <= 0)
        {
            currEnergy -= 2;
            time = 5f;
        }

        if(currEnergy <= 0)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                FindObjectOfType<health>().currHealth -= 5;
                time = 3f;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("can") && currEnergy != maxEnergy)
        {
            currEnergy += 10;
            Destroy(collision.gameObject);
        }
    }
}
