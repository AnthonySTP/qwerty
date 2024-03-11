using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quad : MonoBehaviour
{
    // Start is called before the first frame update
    public float scrollingspeed;
    public bool scroling;
    Material backgroundmaterial;
    private void Awake (){
       backgroundmaterial = GetComponent<Renderer>().material;
    }
    void Start()
    {
        
    }
    private void FixedUpdate(){
        if (scroling){
            Vector2 offset = new Vector2(0,scrollingspeed*Time.time);
            backgroundmaterial.mainTextureOffset =  offset;
            
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
