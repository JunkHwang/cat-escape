using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

// 모노 클래스

public class App : MonoBehaviour // 컴포넌트를 부착해서 인스턴스화
{
    [SerializeField]
    private GameObject playerGo;

    [SerializeField]
    private float speed = 1;


    //[SerializeField]
    //private Transform a;
    //[SerializeField]
    //private Transform b;
    ////열거형식 정의
    //public enum PlatformType
    //{
    //    pc, Android, ios
    //}

    //[SerializeField]
    //private PlatformType platformtype;

    //// 맴버 변수 
    //[SerializeField]
    //public int hp = 10;

    //[SerializeField]
    //private float exp = 11.33f;

    //[SerializeField]
    //private bool isGameOver = false;

    //[SerializeField]
    //private string appName = "MyApp";

    //[SerializeField]
    //private GameObject[] arrGameobj; // 정적배열

    //[SerializeField]
    //private List<Transform> arrTransform; //동적배열

    private void Awake()// 매개변수(지역변수)
    {

        //Debug.Log("awake");
        //// 지역변수
        //Debug.LogFormat("hp: {0}", hp);
    }
    void Start()// 맴버 메서드
    {
        //Debug.LogFormat("a: {0}", a);
        //// a변수 값인 Transform컴포넌트가 붙어 있는 게임오브젝트를 알고싶다
        //Debug.LogFormat("a.gameObject: {0}", a.gameObject);

        //Debug.LogFormat("b. {0}", b);
        //Debug.LogFormat("b: {0}", b);


        //두 벡터의 뺄셈 연산
        //연산 결과 : 방향 벡터 (새로운 벡터)
        //Vector3 c = b.position- a.position ;
        //Debug.LogFormat("{0}",c);
        //DrawArrow.ForDebug(a.position, c, 10, Color.yellow, ArrowType.Solid);

        //Debug.LogFormat("c.magnitude: {0}", c.magnitude); // 벡터의 길이를 반환
        //Vector3 normal = c.normalized; //단위 벡터 (길이가 1인 벡터 : 방향)
        //Debug.LogFormat("normal{0}", normal);

        //App 인스턴스
        //this (c# script) .gameObject (objApp) .transform (component)


        //Debug.Log("Start");

        //Debug.Log("a: {0}", a);
        //Debug.Log("b: {0}", b);

        //Vector3 c = b.position - a.position;
        //Debug.LogFormat("c: {0}", c);

        //DrawArrow.ForDebug(a.position, c, 10, Color.red);

        // 클래스의 현재 인스턴스
        //this.
        //현재 인스턴스(컴포넌트)가 붙어 있는 게임오브젝트
        //this.gameObject
        //App컴포넌트가 붙어 있는 게임오브젝트의 트랜스폼 컴포넌트
        //this.gameObject.transform

        //App 컴포넌트가 붙어 있는 게임오브젝트의 트랜스폼의 포지션 속성
        //this.gameObject.transform.position

        //Vector3 pos = this.gameObject.transform.position;
        //Debug.Log(pos);

        //Vector3 ppa = this.transform.position;
        //Debug.Log(ppa);

        //Debug.Log(this);
        //Debug.Log(this.gameObject);
        //Debug.Log(this.gameObject.transform);
        //Debug.Log(this.gameObject.transform.position);

        //this.transform.position = new Vector3(0, 0, 1);

        //Vector3 targetPosition = this.transform.position;
        //targetPosition = this.transform.position + new Vector3(0, 0, 17);
        //Debug.LogFormat("targetPosition: {0}", targetPosition);

        Vector2 playerPos = new Vector2(3.0f, 4.0f);

        playerGo.transform.position = playerPos;

        playerPos.x += 8.0f;
        playerPos.y += 5.0f;

        Debug.LogFormat("playerGO.transform.position: {0}", playerGo.transform.position);

        Debug.LogFormat("playerPos: {0}", playerPos);

        playerGo.transform.position = playerPos;
    }

    private void Update()
    {
        //Console.WriteLine("업뎃");
        //Debug.Log("UPDAT");

        //방향 * 속도 * 시간
        //Vector3 pos = new Vector3(0.001f, 0);
        //playerGo.transform.position += pos; 


        
        playerGo.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
