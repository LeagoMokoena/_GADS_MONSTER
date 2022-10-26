using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public static GameManger instance;
    private void Awake()
    {
        instance = this;
    }

    public List<Sprite> cansprites;
    public List<Sprite> monstersprites;

    public PLayer player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
