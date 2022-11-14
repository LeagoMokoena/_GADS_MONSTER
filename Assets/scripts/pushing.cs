using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushing : MonoBehaviour
{
    private GameObject[] ob;
    private GameObject[] boxes;

    public float dis = 1f;
    public LayerMask boxmask;
    // Start is called before the first frame update
    void Start()
    {
        ob = GameObject.FindGameObjectsWithTag("obstacle");
        boxes = GameObject.FindGameObjectsWithTag("box");
    }

    // Update is called once per frame
    /*void Update()
    {
        Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, dis, boxmask)
    }

    public bool Move(Vector2 dir)
    {
        if()
    }*/
}
