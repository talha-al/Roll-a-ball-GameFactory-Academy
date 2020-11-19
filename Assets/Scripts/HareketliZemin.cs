using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketliZemin : MonoBehaviour
{
    [SerializeField]
    private float _minX, _maxX, speed;
    Rigidbody _rb;
    private bool zeminKontrol;
    void Start()
    {
        zeminKontrol = true;
        _rb = GetComponent<Rigidbody>();
    }


    void Update()
    {

        if (transform.position.x <= _minX)
        {
            _rb.velocity = new Vector3(speed, 0, 0);
            zeminKontrol = true;
        }

        else if (transform.position.x >= _maxX || (transform.position.x >=_minX && !zeminKontrol))
        {
            _rb.velocity = new Vector3(-speed, 0, 0);
            zeminKontrol = false;
        }

        else if (transform.position.x <= _maxX && zeminKontrol)
        {
            _rb.velocity = new Vector3(speed, 0, 0);

        }
    }
}
