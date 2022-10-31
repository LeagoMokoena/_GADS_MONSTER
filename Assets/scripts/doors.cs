using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doors : MonoBehaviour
{
    public string room;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(room);
    }
}
