using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWinScript : MonoBehaviour
{
    public GameObject Obstacles, winPanel;
    bool gamewin;
    public LevelManager levelManager;
    public GameObject ballThrower;
     

    // Start is called before the first frame update
    void Start()
    {
        winPanel = GameObject.Find("Panel"); winPanel.SetActive(false);
        //Obstacles = GameObject.FindGameObjectsWithTag("Obstacles");
    }

    // Update is called once per frame
    void Update()
    {

        GameWin();

    }
    public void GameWin()
    {
        gamewin = true;
        for (int i = 0; i < Obstacles.transform.childCount; i++)
        {
            if (Obstacles.transform.GetChild(i).gameObject.activeInHierarchy)
            {
                gamewin = false;
                

            }

        }
        
        

        if (gamewin == false)
        {
            //Debug.Log(" still left");
        }
        else
        {
            //Debug.Log(" you won ??!!!!!");
            ballThrower.SetActive(false);
            winPanel.SetActive(true);
        }
    }

    public void NextLevel()
    {
        StartCoroutine(levelManager.LoadNextLevel());

        //levelManager.LoadNextLevel();
    }


}
