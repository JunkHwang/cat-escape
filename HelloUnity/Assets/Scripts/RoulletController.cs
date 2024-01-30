using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoulletController : MonoBehaviour
{
    [SerializeField]
    private float speed = 0;
    [SerializeField]
    private float maxSpeed = 2;
    [SerializeField]
    private float attenuation = 0.98f;
    // 1. 마우스 왼쪽 클릭을 하면
    // 2. 회전한다.
    // 3. 서서히 멈춘다
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)){
            speed = maxSpeed;
        }
        this.transform.Rotate(0, 0, speed * Time.deltaTime);

        speed *= attenuation;

        if (speed < 0.1f){
            speed = 0;
        }
        else
        {
            Debug.LogFormat("현재 속도는 {0}입니다.", speed * Time.deltaTime);

            
        }

       
    }
}
