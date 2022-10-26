using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    public ContactFilter2D filter;
    private BoxCollider2D boxcollider;
    private Collider2D[] hits = new Collider2D[10];

    // Start is called before the first frame update
    protected virtual void Start()
    {
        boxcollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        boxcollider.OverlapCollider(filter, hits);
        for(int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
                continue;

            hits[i] = null;
        }
    }
}
