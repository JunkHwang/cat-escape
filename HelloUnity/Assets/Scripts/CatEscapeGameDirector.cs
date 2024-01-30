using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;



public class CatEscapeGameDirector : MonoBehaviour
{
    [SerializeField] private Image hpGauege;

    
    public void decreaseHp()
    {
        this.hpGauege.fillAmount -= 0.1f;
    }
}
