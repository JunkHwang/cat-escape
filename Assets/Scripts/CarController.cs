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
        // 왼쪽 버튼을 눌렀다면
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("화면 터치 시작");
            //화면을 터치한 위치 가져오기
            Debug.Log(Input.mousePosition);
            this.startPosition = Input.mousePosition;
            //speed = maxSpeed;
            
        }else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("화면에서 손을 땜");
            Debug.Log(Input.mousePosition);
            float length = Input.mousePosition.x - this.startPosition.x;
            Debug.Log(length);


            Debug.Log(length / deviedLength);
            speed = length / deviedLength;
            Debug.LogFormat("<color=yellow>speed: {0}</color>",speed);

            //터치한 지점

            //화면에서 손을 뗀 지점.x - 터치한 지점의 x 
        }
        // 0.1유닛씩 매 프레임 마다 이동합니다
        this.gameObject.transform.Translate(new Vector3(speed, 0, 0));

        speed = speed * attenAttenuation;
    }
}
