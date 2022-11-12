using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class save : MonoBehaviour
{
    public static void saves(PLayer player)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string pa = Application.persistentDataPath + "/player/";
        FileStream strea = new FileStream(pa, FileMode.Create);

        
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
