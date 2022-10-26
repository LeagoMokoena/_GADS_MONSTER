using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doors : MonoBehaviour
{
    public string room;

    protected override void oncollision(Collider2D collider)
    {
        if(collider.name == "Player")
        {
            SceneManager.LoadScene(room);
        }
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
