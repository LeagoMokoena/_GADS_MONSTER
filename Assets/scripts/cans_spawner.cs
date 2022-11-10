using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cans_spawner : MonoBehaviour
{
    public GameObject can1;
    public GameObject can2;
    public GameObject can3;
    public int canid;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            canid = Random.Range(0, 2);
            if (canid == 0)
            {
                Vector2 randeom = new Vector2(Random.Range(-23, 23), Random.Range(-2, 2));
                Instantiate(can1, randeom, Quaternion.identity);
            }
            else if (canid == 1)
            {
                Vector2 randeom = new Vector2(Random.Range(-23, 23), Random.Range(-2, 2));
                Instantiate(can2, randeom, Quaternion.identity);
            }
            else
            {
                Vector2 randeom = new Vector2(Random.Range(-23, 23), Random.Range(-2, 2));
                Instantiate(can3, randeom, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

}
