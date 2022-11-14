using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doors : MonoBehaviour
{
    public GameObject room;
    public GameObject prevous;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        room.SetActive(true);
        prevous.SetActive(false);
    }
}
