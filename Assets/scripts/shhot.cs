using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shhot : MonoBehaviour
{
    public GameObject cros;
    private Vector2 tar;
    // Start is called before the first frame update
    void Start()
    {
        tar = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        cros.transform.position = new Vector2(tar.x, tar.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
