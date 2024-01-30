using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    
    // �������� �����Ǵ� �ִ� ���� �ִ°� Assign �Ұ���
    private CatEscapeGameDirector gameDirector;
    public float radius = 1;
    private GameObject playerGo;

    // Start is called before the first frame update

    private void Start()
    {
        // �̸����� ���ӿ�����Ʈ�� ã�´�
        this.playerGo = GameObject.Find("player");

        // Ÿ������ ã�´� = ������Ʈ�� ã�´�
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
            //Debug.LogError("�߻�");

            Destroy(this.gameObject);
            //Destroy(this); -> ������Ʈ ����
        }


        Vector2 p1 = this.transform.position;
        Vector2 p2 = this.playerGo.transform.position;
        Vector2 dir = p1 - p2; // ����
        float distance = dir.magnitude; //�Ÿ�

        float r1 = this.radius;
        float r2 = this.radius;
        float sumRadius = r1 + r2;

        if(distance < sumRadius ) // �浹��
        {
            Debug.LogFormat("�浹�� {0},{1}", distance, sumRadius);
            Destroy(this.gameObject); // ������ ����

            this.gameDirector.decreaseHp();
        }

       
    }
    

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }
}
