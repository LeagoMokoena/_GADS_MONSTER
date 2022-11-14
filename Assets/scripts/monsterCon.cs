using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterCon : MonoBehaviour
{
    private Transform tar;
    public Transform station;
    [SerializeField]
    private float sp;
    [SerializeField]
    private float mnran;
    public float mxran;

    // Start is called before the first frame update
    private void Start()
    {
        tar = FindObjectOfType<PLayer>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(tar.position, transform.position) <= mxran && Vector3.Distance(tar.position, transform.position) >= mnran)
        {
            follow();
        }
        else
        {
            home();
        }
    }

    public void follow()
    {
        transform.position = Vector3.MoveTowards(transform.position, tar.transform.position, sp * Time.deltaTime);

    }

    public void home()
    {
        transform.position = Vector3.MoveTowards(transform.position, station.position, sp * Time.deltaTime);
    }
}
