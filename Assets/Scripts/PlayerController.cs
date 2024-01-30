using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float radius = 1;
    private float max = 0;
    [SerializeField] private float x = 0;
    [SerializeField] private float y = 0;

    




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

        //키보드 입력을 받는 코드 작성 
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽으로 2유닛만큼 이동");
            //X 축으로-2만큼 이동 
            this.transform.Translate(-1, 0, 0);
        }
       

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            Debug.Log("오른쪽으로 2유닛만큼 이동");
            //X축으로 2만큼 이동 
            this.transform.Translate(1, 0, 0);
        }
        float maxLength = Mathf.Clamp(this.transform.position.x, -8, 8);
        this.transform.position = new Vector3(maxLength, -3.52f, 0);

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }
}
