using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    //������ ������ ������ ������ �ν��͸� �����.
    [SerializeField] private GameObject ArrowPrefab;
    private float delta;


    //void Start()
    //{
    //    GameObject go =Instantiate(this.ArrowPrefab);

    //    //������ ���¿� ������ ��ġ
    //    Debug.LogFormat("go : {0}", go);
    //}

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime; // ���� �����Ӱ� ���� ������ ���� �ð�
        //Debug.Log(delta);
        if(delta > 3)
        {
            GameObject go = UnityEngine.Object.Instantiate(ArrowPrefab);
            //��ġ �� ����
            float randX = Random.Range(-8,9);
            go.transform.position = new Vector3(randX, go.transform.position.y,go.transform.position.z);
            delta = 0;
        }
    }
}
