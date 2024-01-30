using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float jumpForce = 680f;
    [SerializeField] private float moveForce = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //점프
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rbody.AddForce(this.transform.up * this.jumpForce);
        }
        // 오른쪽 이동
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.rbody.AddForce(this.transform.right * this.moveForce);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.rbody.AddForce(this.transform.right * this.moveForce*-1);
        }

    }
}
