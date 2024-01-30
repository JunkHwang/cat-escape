using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameDirector : MonoBehaviour
{
    private GameObject carGo;
    private GameObject flagGo;
    private GameObject distanceTextGo;
    private float length = 0.00f;
    private Text distanceText;
    
    void Start()
    {
        this.carGo = GameObject.Find("car");
        Debug.LogFormat("this.carGo : {0}",this.carGo); // car ���ӿ�����Ʈ �ν��Ͻ�
        this.flagGo = GameObject.Find("flag");
        Debug.LogFormat("this.flagGo : {0}",this.flagGo); // car ���ӿ�����Ʈ �ν��Ͻ�
        this.distanceTextGo = GameObject.Find("distance");
        Debug.LogFormat("this.distance : {0}",this.distanceTextGo); // car ���ӿ�����Ʈ �ν��Ͻ�


        Debug.LogFormat("distanceText : {0}", distanceText);

        
        
        


    }

    // Update is called once per frame
    void Update()
    {
        //wk
        this.length = this.flagGo.transform.position.x - this.carGo.transform.position.x;
        string convertLength = length.ToString("#.##");
        Text distanceText =this.distanceTextGo.GetComponent<Text>();
        distanceText.text = "���� �Ÿ� : "+convertLength + "m";
        //Debug.Log(length);
    }
}
