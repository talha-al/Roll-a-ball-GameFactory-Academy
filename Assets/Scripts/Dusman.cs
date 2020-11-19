using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    [SerializeField]
    private float _patrolRange, speed;

    private Vector3 initialPos, destinationPoint;
    private Vector3 _minPatrolPos, _maxPatrolPos;

    KarakterKontrol _karakterKont;

    private void Awake()
    {

        _karakterKont = GameObject.FindGameObjectWithTag("karakter").GetComponent<KarakterKontrol>();
        initialPos = transform.position;

        _minPatrolPos = initialPos + Vector3.left * _patrolRange;
        _maxPatrolPos = initialPos + Vector3.right * _patrolRange;
        HareketEttirme(_maxPatrolPos);

    }

    void Update()
    {
        //float x = Mathf.Cos(Time.time*20) * genislik;
        //transform.position = new Vector3(x, 0, 0);

        if (Mathf.Abs(Vector3.Distance(transform.position, _maxPatrolPos)) < 0.1f)
        {
            HareketEttirme(_minPatrolPos);
        }
        else if (Mathf.Abs(Vector3.Distance(transform.position, _minPatrolPos)) < 0.1f)
        {
            HareketEttirme(_maxPatrolPos);
        }

        transform.position = Vector3.MoveTowards(transform.position, destinationPoint, Time.deltaTime * speed);


    }

    private void HareketEttirme(Vector3 destination)
    {
        destinationPoint = destination;
    }

}
