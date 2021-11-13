using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ObstacleManager : MonoBehaviour
{
    public float life;
    public TextMeshPro[] textElements;
    // public Material[] color;
    public GameObject smokeExplode;
    public GameObject lightning;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        ObsManager();  
    }

    // Update is called once per frame
    void Update()
    {
        ObsManager();
    }

    public void ObsManager()
    {
        //ColorChange();
        TextChange();
    }


    private void TextChange()
    {
        foreach (TextMeshPro item in textElements)
        {
            item.text = life.ToString();
        }
        
    }

    //private void ColorChange()
    //{
    //     if(color.Length * 10 >= life)
    //    {
    //        GetComponent<MeshRenderer>().material = color[(int)(life / 10)];
    //    }
    //    else
    //    {
    //        GetComponent<MeshRenderer>().material = color[(color.Length - 1)];
    //    }
         
        
            
        
    //}
    private void OnCollisionEnter(Collision collision)
    {
        
        foreach (ContactPoint contact in collision.contacts)
        {
           
            if(contact.otherCollider.CompareTag("ball"))
            {
                
                //life--;
                ball b = contact.otherCollider.GetComponent<ball>();
                life -= b.ballPower;
                Instantiate(lightning, transform.position, Quaternion.identity);
                ObsManager();

                if(life <= 0 || b.powerBall)
                {
                    DestroyMe();
                }
                
            }
            

        }
    }

    void DestroyMe()
    {
        StartCoroutine(StartLightning());
        
    }

    private IEnumerator StartLightning()
    {
        Instantiate(smokeExplode, transform.position, Quaternion.identity);
        WaitForSeconds wait = new WaitForSeconds(.2f);
        yield return wait;
        
        gameObject.SetActive(false);

    }
    

}
