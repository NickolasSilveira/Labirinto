using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour
{
    public float Velocidade = 5f;
    //public Transform PontoMov;
    public Vector2 DestinoTeleporte1;
    public Vector2 DestinoTeleporte2;
    public Vector2 DestinoTeleporte3;
    public Vector2 DestinoTeleporte4;
    public Vector2 DestinoTeleporte5;
    public Vector2 DestinoTeleporte6;
    public Vector2 DestinoTeleporte7;
    public Vector2 DestinoTeleporte8;
    public Vector2 DestinoTeleporte9;
    public Vector2 DestinoTeleporte10;
    float mH;
    float mV;
    private Rigidbody2D rigid;


    void Start()
    {
        // PontoMov.parent = null;
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        mH = Input.GetAxis("Horizontal");
        rigid.velocity = new Vector3(mH * Velocidade, rigid.velocity.y);
        mV = Input.GetAxis("Vertical");
        rigid.velocity = new Vector3(mV * Velocidade, rigid.velocity.x);



        //transform.position = Vector3.MoveTowards(transform.position,PontoMov.position, Velocidade * Time.deltaTime);

        //if (Vector3.Distance(transform.position, PontoMov.position) == 0f)
        //{

        //if (Mathf.Abs(Input.GetAxis("Horizontal")) == 1f)
       // {
          // PontoMov.position += new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        // }

       // if (Mathf.Abs(Input.GetAxis("Vertical")) == 1f)
         //{
         //  PontoMov.position += new Vector3(0f, Input.GetAxis("Vertical"), 0f);
        // }
         
       // }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Armadilhas")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Teleporte1")
        {
            transform.position = DestinoTeleporte1;
        }
        if (collision.gameObject.tag == "Teleporte2")
        {
            transform.position = DestinoTeleporte2;
        }
        if (collision.gameObject.tag == "Teleporte3")
        {
            transform.position = DestinoTeleporte3;
        }
        if (collision.gameObject.tag == "Teleporte4")
        {
            transform.position = DestinoTeleporte4;
        }
        if (collision.gameObject.tag == "Teleporte5")
        {
            transform.position = DestinoTeleporte5;
        }
        if (collision.gameObject.tag == "Teleporte6")
        {
            transform.position = DestinoTeleporte6;
        }
        if (collision.gameObject.tag == "Teleporte7")
        {
            transform.position = DestinoTeleporte7;
        }
        if (collision.gameObject.tag == "Teleporte8")
        {
            transform.position = DestinoTeleporte8;
        }
        if (collision.gameObject.tag == "Teleporte9")
        {
            transform.position = DestinoTeleporte9;
        }
        if (collision.gameObject.tag == "Teleporte10")
        {
            transform.position = DestinoTeleporte10;
        }
    }  
}
