using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    Vector3 mesafe, sonPos;
    [SerializeField]
    private float yumusatmaOrani;
    public GameObject küre;

    void Start()
    {
        mesafe = this.transform.position - küre.transform.position;

    }


    void LateUpdate()
    { 
        this.transform.position = Vector3.Lerp(transform.position, küre.transform.position + mesafe, yumusatmaOrani);
    }
}
