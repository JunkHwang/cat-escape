using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App2 : MonoBehaviour
{
    [SerializeField] private Transform b; //child

    private void Start()
    {
        Debug.LogFormat("b.position : {0}", b.position); // world space
        Debug.LogFormat("b.localPosition : {0}", b.localPosition) ; // local space
    }
}
