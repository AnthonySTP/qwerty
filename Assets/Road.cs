using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake(){
        string [] cars = {"Racing car","Formula 1 ","Sports car ","BMW","Lotus","Ferrari","Porsche","Audi","Lexus","Normal car","Police car"};
       for(int i = 0; i<cars.Length;i++){
        Debug.Log(cars[i])
       }
    }
}