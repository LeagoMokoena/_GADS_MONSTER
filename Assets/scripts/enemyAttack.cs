using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    private health player;
    public float wait = 2f;
    public bool touched;
    [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (touched)
        {
            wait -= Time.deltaTime;
            if(wait <= 0)
            {
                player.hurt(10);

                wait = 2f;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            collision.gameObject.GetComponent<health>().hurt(10);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            touched = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            touched = false;
            wait = 2f;
        }
    }
}
