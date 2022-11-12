using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject Box1;
    public GameObject Box2;

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
                Instantiate(Box1, randeom, Quaternion.identity);
            }
            else if (canid == 1)
            {
                Vector2 randeom = new Vector2(Random.Range(-23, 23), Random.Range(-2, 2));
                Instantiate(Box2, randeom, Quaternion.identity);
            }

        }
    }
    public bool Move(Vector2 direction)
    {
        if (BoxBlocked(transform.position, direction))
        {
            return false;
        }
        else
        {
            transform.Translate(direction);

            return true;
        }
    }

    bool BoxBlocked(Vector3 position, Vector2 direction)
    {
        Vector2 newPos = new Vector2(position.x, position.y) + direction;
        GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");
        foreach (var wall in walls)
        {
            if(wall.transform.position.x == newPos.x && wall.transform.position.y == newPos.y)
            {
                return true;
            }

        }
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
        foreach (var box in boxes)
        {
            if (box.transform.position.x == newPos.x && box.transform.position.y == newPos.y)
            {
                return true;
            }

        }
        return false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
