using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntuacionScript : MonoBehaviour
{
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;
    public GameObject ball6;
    public GameObject ball7;
    public GameObject ball8;
    public GameObject ball9;
    public GameObject ball10;
    public TMP_Text text1;
    public TMP_Text text2;
    public TMP_Text text3;
    public TMP_Text text4;
    // Update is called once per frame
    void Update()
    {
        int counter = 10;
        if(ball1.transform.position.y <-1f){
            counter --;
        }
        if(ball2.transform.position.y <-1f){
            counter --;
        }
        if(ball3.transform.position.y <-1f){
            counter --;
        }
        if(ball4.transform.position.y <-1f){
            counter --;
        }
        if(ball5.transform.position.y <-1f){
            counter --;
        }
        if(ball6.transform.position.y <-1f){
            counter --;
        }
        if(ball7.transform.position.y <-1f){
            counter --;
        }
        if(ball8.transform.position.y <-1f){
            counter --;

        }
        if(ball9.transform.position.y <-1f){
            counter --;

        }
        if(ball10.transform.position.y <-1f){
            counter --;

        }
        this.text1.SetText( counter+" balls reamining");
        this.text2.SetText( counter+" balls reamining");
        this.text3.SetText( counter+" balls reamining");
        this.text4.SetText( counter+" balls reamining");

        
        
    }
}
