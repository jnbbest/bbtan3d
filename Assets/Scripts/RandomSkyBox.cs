using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSkyBox : MonoBehaviour
{

    public Material[] skyboxes;
    
    // Use this for initialization
    void Start()
    {
        ChangeMySkybox();
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void ChangeMySkybox()
    {
        int x = Random.Range(0, skyboxes.Length - 1);
        RenderSettings.skybox = skyboxes[x];
    }
    
}
    

