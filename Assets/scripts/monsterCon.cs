using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterCon : MonoBehaviour
{
    private Transform tar;
    [SerializeField]
    private float sp;
    [SerializeField]
    private float ran;

    // Start is called before the first frame update
    private void Start()
    {
        tar = FindObjectOfType<PLayer>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        follow();
    }

    public void follow()
    {
        transform.position = Vector3.MoveTowards(transform.position, tar.transform.position, sp * Time.deltaTime);

    }
}
