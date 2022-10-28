using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class energy_detecter : MonoBehaviour
{
    public Slider slid;
    public GameObject[] cans;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i =0; i < cans.Length; i++)
        {
            if(cans[i].gameObject == null)
            {
                slid.value++;
            }
        }


    }
}
