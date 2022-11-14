using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_Spawner : MonoBehaviour
{
    public GameObject can1;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
                Vector2 randeom = new Vector2(Random.Range(-23, 23), Random.Range(-2, 2));
                Instantiate(can1, randeom, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
