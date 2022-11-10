using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class energy_detecter : MonoBehaviour
{
    public float time = 1f;
    public int currEnergy;
    public int maxEnergy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        time -= Time.deltaTime;
        if(time <= 0)
        {
            currEnergy -= 5;
            time = 3f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "can" && currEnergy != maxEnergy)
        {
            currEnergy += 10;
            Destroy(collision.gameObject);
        }
    }
}
