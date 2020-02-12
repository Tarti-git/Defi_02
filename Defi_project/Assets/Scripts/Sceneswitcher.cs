using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sceneswitcher : MonoBehaviour
{
    // Start is called before the first frame update
    public void changescene(string scenename)
    {
        Application.LoadLevel(scenename);
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
