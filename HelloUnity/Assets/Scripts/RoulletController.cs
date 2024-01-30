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
    // 1. ���콺 ���� Ŭ���� �ϸ�
    // 2. ȸ���Ѵ�.
    // 3. ������ �����
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
            Debug.LogFormat("���� �ӵ��� {0}�Դϴ�.", speed * Time.deltaTime);

            
        }

       
    }
}
