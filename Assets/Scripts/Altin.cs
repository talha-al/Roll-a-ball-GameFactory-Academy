using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altin : MonoBehaviour
{
    [SerializeField]
    private float dönüsHizi;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 90) * dönüsHizi);

    }
    
}
