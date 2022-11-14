using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUZZLE2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject []box1; 
    public float boxes = 0;
    public GameObject door;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (boxes == 5)
        {
            door.SetActive(true);
        }
    }
}
