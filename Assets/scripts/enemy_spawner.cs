using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawner : MonoBehaviour
{
    public GameObject ene1;
    public GameObject ene2;
    public GameObject ene3;
    public GameObject ene4;
    public int canid;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            canid = Random.Range(0, 2);
            if (canid == 0)
            {
                Vector2 randeom = new Vector2(Random.Range(-23, 23), Random.Range(-2, 2));
                Instantiate(ene1, randeom, Quaternion.identity);
            }
            else if (canid == 1)
            {
                Vector2 randeom = new Vector2(Random.Range(-23, 23), Random.Range(-2, 2));
                Instantiate(ene2, randeom, Quaternion.identity);
            }
            else if (canid == 2)
            {
                Vector2 randeom = new Vector2(Random.Range(-23, 23), Random.Range(-2, 2));
                Instantiate(ene3, randeom, Quaternion.identity);
            }
            else
            {
                Vector2 randeom = new Vector2(Random.Range(-23, 23), Random.Range(-2, 2));
                Instantiate(ene4, randeom, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
