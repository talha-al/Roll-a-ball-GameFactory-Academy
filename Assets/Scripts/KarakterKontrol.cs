using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KarakterKontrol : MonoBehaviour
{
    Rigidbody _rb;
    MeshRenderer _mesh;
    OyunKontrol _okScript;

    [SerializeField]
    private float ziplamaGücü, hiz;

    public bool _isGround, hareketKontrol;
    private float yatay, ziplama;
    private int canSayac = 2;
    public Vector3 startPos;

    void Start()
    {
        hareketKontrol = true;
        startPos = transform.position;
        _isGround = true;
        _rb = GetComponent<Rigidbody>();
        _mesh = GetComponent<MeshRenderer>();
        _okScript = GameObject.FindGameObjectWithTag("OyunKontrol").GetComponent<OyunKontrol>();

    }

    void FixedUpdate()
    {
        Hareket();
    }

    private void Hareket()
    {
        if (hareketKontrol)
        {
            yatay = Input.GetAxis("Horizontal");
            ziplama = ziplamaGücü * Input.GetAxis("Jump");

            _rb.AddForce(new Vector3(yatay * hiz, 0, 0));

            if (_isGround)
            {
                _rb.AddForce(new Vector3(0, ziplama, 0), ForceMode.Impulse);

            }

        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            _isGround = true;
        }

        if (collision.gameObject.tag == "dusman")
        {
            _mesh.enabled = false;
            _okScript.canlar[canSayac].enabled = false;
            canSayac--;

            if (canSayac < 0)
            {
                SceneManager.LoadScene("AnaMenü");
            }

            StartCoroutine(YenidenDogma());

        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")

        {
            _isGround = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            _isGround = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "altin")
        {
            other.gameObject.SetActive(false);
            _okScript.skor += 10;
        }

        if (other.gameObject.tag == "ziplama")
        {
            _rb.AddForce(new Vector3(0, 500, 0), ForceMode.Acceleration);
        }

        if (other.gameObject.tag == "cukur")
        {
            _mesh.enabled = false;
            _okScript.canlar[canSayac].enabled = false;
            canSayac--;

            if (canSayac < 0)
            {
                SceneManager.LoadScene("AnaMenü");
            }

            StartCoroutine(YenidenDogma());
        }

        if (other.gameObject.tag == "son")
        {
            PlayerPrefs.SetInt("bolum", Application.loadedLevel);
            SceneManager.LoadScene("Gecis");
            hareketKontrol = false;
        }
    }

    private IEnumerator YenidenDogma()
    {
        yield return new WaitForSeconds(1f);
        transform.position = startPos;
        _mesh.enabled = true;

    }

}
