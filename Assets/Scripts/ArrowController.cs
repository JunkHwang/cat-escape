using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    
    // 동적으로 생성되는 애는 씬에 있는거 Assign 불가능
    private CatEscapeGameDirector gameDirector;
    public float radius = 1;
    private GameObject playerGo;

    // Start is called before the first frame update

    private void Start()
    {
        // 이름으로 게임오브젝트를 찾는다
        this.playerGo = GameObject.Find("player");

        // 타입으로 찾는다 = 컴포넌트로 찾는다
        this.gameDirector = GameObject.FindObjectOfType<CatEscapeGameDirector>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 movemet = Vector3.down * speed * Time.deltaTime;
        this.transform.Translate(movemet);
        // Debug.LogFormat("y : ", this.transform.position.y);

        if (this.transform.position.y <= -5.09f)
        {
            //Debug.LogError("삐뽀");

            Destroy(this.gameObject);
            //Destroy(this); -> 컴포넌트 삭제
        }


        Vector2 p1 = this.transform.position;
        Vector2 p2 = this.playerGo.transform.position;
        Vector2 dir = p1 - p2; // 방향
        float distance = dir.magnitude; //거리

        float r1 = this.radius;
        float r2 = this.radius;
        float sumRadius = r1 + r2;

        if(distance < sumRadius ) // 충돌함
        {
            Debug.LogFormat("충돌함 {0},{1}", distance, sumRadius);
            Destroy(this.gameObject); // 씬에서 제거

            this.gameDirector.decreaseHp();
        }

       
    }
    

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }
}
