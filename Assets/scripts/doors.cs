using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doors : collider
{
    public string room;

    protected override void oncollide(Collider2D collider)
    {
        if(collider.name == "Player")
        {
            SceneManager.LoadScene(room);
        }
    }
}
