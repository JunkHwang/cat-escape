using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float attenAttenuation = 0.98f;
    [SerializeField] private float deviedLength = 500f;

        private float speed = 0;
    private Vector3 startPosition;
    private Vector3 endPosition;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            this.transform.position = new Vector3(-7.43f,-2.27f,0);
        }
        // ���� ��ư�� �����ٸ�
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("ȭ�� ��ġ ����");
            //ȭ���� ��ġ�� ��ġ ��������
            Debug.Log(Input.mousePosition);
            this.startPosition = Input.mousePosition;
            //speed = maxSpeed;
            
        }else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("ȭ�鿡�� ���� ��");
            Debug.Log(Input.mousePosition);
            float length = Input.mousePosition.x - this.startPosition.x;
            Debug.Log(length);


            Debug.Log(length / deviedLength);
            speed = length / deviedLength;
            Debug.LogFormat("<color=yellow>speed: {0}</color>",speed);

            //��ġ�� ����

            //ȭ�鿡�� ���� �� ����.x - ��ġ�� ������ x 
        }
        // 0.1���־� �� ������ ���� �̵��մϴ�
        this.gameObject.transform.Translate(new Vector3(speed, 0, 0));

        speed = speed * attenAttenuation;
    }
}
