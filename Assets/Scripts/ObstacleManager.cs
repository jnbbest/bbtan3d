using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ObstacleManager : MonoBehaviour
{
    public float life;
    public TextMeshPro[] textElements;
    public Material[] color;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ObsManager()
    {
        ColorChange();
        TextChange();
    }


    private void TextChange()
    {
        foreach (TextMeshPro item in textElements)
        {
            item.text = life.ToString();
        }
        
    }

    private void ColorChange()
    {
         if(color.Length * 10 >= life)
        {
            GetComponent<MeshRenderer>().material = color[(int)(life / 10)];
        }
        else
        {
            GetComponent<MeshRenderer>().material = color[(color.Length - 1)];
        }
         
        
            
        
    }

}
