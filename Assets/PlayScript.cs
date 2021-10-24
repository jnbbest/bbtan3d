using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    //public LevelManager levelManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        int sceneIndex = PlayerPrefs.GetInt("sceneIndex", 1);//
        //LevelManager level = new LevelManager();
        //StartCoroutine(level.LoadNextLevel());
        SceneManager.LoadScene(sceneIndex);
    }
}
