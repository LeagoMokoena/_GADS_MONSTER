using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jem : MonoBehaviour
{
    public bool found;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            found = true;
            door.SetActive(true);
            Destroy(gameObject);

        }
    }
}
