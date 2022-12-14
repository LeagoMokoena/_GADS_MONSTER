using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{
    public Transform tar;
    public float hbour = 0.15f;
    public float vbour = 0.05f;

    private void LateUpdate()
    {
        float delx = tar.position.x - transform.position.x;
        if(delx > hbour || delx < -hbour)
        {
            if(transform.position.x < tar.position.x)
            {
                delx = delx - hbour;
            }
            else
            {
                delx = delx + hbour;
            }
        }
        
        float dely = tar.position.y - transform.position.y;
        if(dely > vbour || dely < -vbour)
        {
            if(transform.position.y < tar.position.y)
            {
                dely = dely - vbour;
            }
            else
            {
                dely = dely + vbour;
            }
        }

        transform.position += new Vector3(delx, dely, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
