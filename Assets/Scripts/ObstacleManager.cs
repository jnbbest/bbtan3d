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
        ObsManager();  
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
    private void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            if(contact.otherCollider.CompareTag("ball"))
            {
                life--;
                ObsManager();

                if(life <= 0)
                {
                    DestroyMe();
                }
            }
        }
    }

    void DestroyMe()
    {
        gameObject.SetActive(false);
    }
    

}
