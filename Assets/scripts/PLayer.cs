using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer : MonoBehaviour
{
    private BoxCollider2D boxcollider;
    private RaycastHit2D hit;
    private Vector3 move;



    // Start is called before the first frame update
    void Start()
    {
        boxcollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        move = new Vector3(x, y, 0);

        if (move.x > 0)
            transform.localScale = Vector3.one;
        else if (move.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);

        hit = Physics2D.BoxCast(transform.position, boxcollider.size, 0, new Vector2(0, move.y), Mathf.Abs(move.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            transform.Translate(0, move.y * Time.deltaTime,0);
        }

        hit = Physics2D.BoxCast(transform.position, boxcollider.size, 0, new Vector2(0, move.x), Mathf.Abs(move.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            transform.Translate(move.x * Time.deltaTime,0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("can"))
        {
            Destroy(collision.gameObject);
        }
    }
}
