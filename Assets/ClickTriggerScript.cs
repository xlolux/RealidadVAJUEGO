using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTriggerScript : MonoBehaviour
{
    public GameObject ball;
    private bool taken= false;
    public void Red(){
        GetComponent<Renderer>().material.color = Color.red;
    }
    public void Blue(){
        GetComponent<Renderer>().material.color = Color.blue;
    }
    public void Black(){
        GetComponent<Renderer>().material.color = Color.black;
    }

    public void takeBall(){
        taken=!taken;
    }

    void Update() {
        if(taken){
            ball.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 3;
        }
    }
    
}
