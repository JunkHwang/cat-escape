using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

// ��� Ŭ����

public class App : MonoBehaviour // ������Ʈ�� �����ؼ� �ν��Ͻ�ȭ
{
    [SerializeField]
    private GameObject playerGo;

    [SerializeField]
    private float speed = 1;


    //[SerializeField]
    //private Transform a;
    //[SerializeField]
    //private Transform b;
    ////�������� ����
    //public enum PlatformType
    //{
    //    pc, Android, ios
    //}

    //[SerializeField]
    //private PlatformType platformtype;

    //// �ɹ� ���� 
    //[SerializeField]
    //public int hp = 10;

    //[SerializeField]
    //private float exp = 11.33f;

    //[SerializeField]
    //private bool isGameOver = false;

    //[SerializeField]
    //private string appName = "MyApp";

    //[SerializeField]
    //private GameObject[] arrGameobj; // �����迭

    //[SerializeField]
    //private List<Transform> arrTransform; //�����迭

    private void Awake()// �Ű�����(��������)
    {

        //Debug.Log("awake");
        //// ��������
        //Debug.LogFormat("hp: {0}", hp);
    }
    void Start()// �ɹ� �޼���
    {
        //Debug.LogFormat("a: {0}", a);
        //// a���� ���� Transform������Ʈ�� �پ� �ִ� ���ӿ�����Ʈ�� �˰�ʹ�
        //Debug.LogFormat("a.gameObject: {0}", a.gameObject);

        //Debug.LogFormat("b. {0}", b);
        //Debug.LogFormat("b: {0}", b);


        //�� ������ ���� ����
        //���� ��� : ���� ���� (���ο� ����)
        //Vector3 c = b.position- a.position ;
        //Debug.LogFormat("{0}",c);
        //DrawArrow.ForDebug(a.position, c, 10, Color.yellow, ArrowType.Solid);

        //Debug.LogFormat("c.magnitude: {0}", c.magnitude); // ������ ���̸� ��ȯ
        //Vector3 normal = c.normalized; //���� ���� (���̰� 1�� ���� : ����)
        //Debug.LogFormat("normal{0}", normal);

        //App �ν��Ͻ�
        //this (c# script) .gameObject (objApp) .transform (component)


        //Debug.Log("Start");

        //Debug.Log("a: {0}", a);
        //Debug.Log("b: {0}", b);

        //Vector3 c = b.position - a.position;
        //Debug.LogFormat("c: {0}", c);

        //DrawArrow.ForDebug(a.position, c, 10, Color.red);

        // Ŭ������ ���� �ν��Ͻ�
        //this.
        //���� �ν��Ͻ�(������Ʈ)�� �پ� �ִ� ���ӿ�����Ʈ
        //this.gameObject
        //App������Ʈ�� �پ� �ִ� ���ӿ�����Ʈ�� Ʈ������ ������Ʈ
        //this.gameObject.transform

        //App ������Ʈ�� �پ� �ִ� ���ӿ�����Ʈ�� Ʈ�������� ������ �Ӽ�
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
        //Console.WriteLine("����");
        //Debug.Log("UPDAT");

        //���� * �ӵ� * �ð�
        //Vector3 pos = new Vector3(0.001f, 0);
        //playerGo.transform.position += pos; 


        
        playerGo.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
