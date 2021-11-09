using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    public float waitforseconds = 3f;
    //public LevelManager levelManager;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GameStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private IEnumerator GameStart()
    {
        yield return new WaitForSeconds(waitforseconds);
        int sceneIndex = PlayerPrefs.GetInt("sceneIndex", 1);//
        //LevelManager level = new LevelManager();
        //StartCoroutine(level.LoadNextLevel());
        SceneManager.LoadScene(sceneIndex);

    }
}
