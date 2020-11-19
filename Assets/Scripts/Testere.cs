using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testere : MonoBehaviour
{
    Rigidbody _rb;
    [SerializeField]
    private float dönmeHiz, cikmaHiz;
    [SerializeField]
    private float _minY,_maxY;
    private bool testereKontrol = true;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, -40) * dönmeHiz);

        //_rb.velocity = new Vector3(transform.position.x, Time.deltaTime * 5, transform.position.z);

        if (transform.position.y <= _minY)
        {
            _rb.velocity = new Vector3(transform.position.x, cikmaHiz, transform.position.z);
            testereKontrol = true;
        }

        else if (transform.position.y >= _maxY)
        {
            _rb.velocity = new Vector3(transform.position.x, -cikmaHiz, transform.position.z);
            testereKontrol = false;
        }

        else if(transform.position.y<_maxY && !testereKontrol)
        {
            _rb.velocity = new Vector3(transform.position.x, -cikmaHiz, transform.position.z);
        }

    }

    void Hareket(Vector3 destination)
    {

    }
}
