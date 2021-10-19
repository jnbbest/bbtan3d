using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public Text CurrentLevelText;
    private int currentLvl = 1, NextLvl = 2;
    public BallThrower ballthrower;

    private void Awake()//
    {
        int mainlevel = SceneManager.GetActiveScene().buildIndex;//
        PlayerPrefs.SetInt("Level", mainlevel);//
    }
    void Start()
    {
        instance = this;
        //Levelshowing text setup
        if (PlayerPrefs.GetInt("CurrentLevel") >= 1)//
        {
            CurrentLevelText.text = PlayerPrefs.GetInt("CurrentLevel").ToString();
            currentLvl = PlayerPrefs.GetInt("CurrentLevel");
        }
        else//
        {
            CurrentLevelText.text = 1.ToString();
        }


    }
    public IEnumerator LoadNextLevel()//
    {
        yield return new WaitForSeconds(.01f);

        currentLvl++;
        NextLvl++;
        PlayerPrefs.SetInt("CurrentLevel", currentLvl);
        PlayerPrefs.SetInt("NextLevel", NextLvl);

        //YCManager.instance.OnGameStarted(currentLvl);

        if (SceneManager.GetActiveScene().buildIndex >= 3)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    
}
