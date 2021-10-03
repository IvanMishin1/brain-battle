using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsHandler : MonoBehaviour
{
    private GameHandler gameHandler;
    public float correct;
    public float incorrect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("You LOST:" + GameObject.FindObjectOfType<GameHandler>().TimesLost); 
        }
    }
}
