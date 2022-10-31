using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer : MonoBehaviour
{
    private Rigidbody2D body;

    [SerializeField]
    private float sp;



    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * sp * Time.deltaTime;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("can"))
        {
            Destroy(collision.gameObject);
        }
    }
}
