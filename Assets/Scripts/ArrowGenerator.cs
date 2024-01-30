using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    //프리팹 에셋을 가지고 프리팹 인스터를 만든다.
    [SerializeField] private GameObject ArrowPrefab;
    private float delta;


    //void Start()
    //{
    //    GameObject go =Instantiate(this.ArrowPrefab);

    //    //프리팹 에셋에 설정된 위치
    //    Debug.LogFormat("go : {0}", go);
    //}

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime; // 이전 프레임과 현재 프레임 사이 시간
        //Debug.Log(delta);
        if(delta > 3)
        {
            GameObject go = UnityEngine.Object.Instantiate(ArrowPrefab);
            //위치 재 설정
            float randX = Random.Range(-8,9);
            go.transform.position = new Vector3(randX, go.transform.position.y,go.transform.position.z);
            delta = 0;
        }
    }
}
