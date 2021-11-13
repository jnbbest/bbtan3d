using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class LogScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = " Index " + " " + SceneManager.GetActiveScene().name + 
            " " + " Total " + LevelManager.instance.numberOFLevels;
    }

}
