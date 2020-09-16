using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alavanca4 : MonoBehaviour
{
    public GameObject Poste3B;
    public GameObject Poste2B;
    public GameObject Poste1B;
    public GameObject Poste3A;
    public GameObject Poste2A;
    public GameObject Poste1A;
    public GameObject Poste1C;
    public GameObject Poste2C;
    public GameObject Poste3C;
    public GameObject Poste4C;
    public GameObject Poste5C;
    public GameObject Poste1D;
    public GameObject Poste2D;
    public GameObject Poste3D;
    public GameObject Poste4D;
    public GameObject Poste5D;
    public GameObject Poste6D;
    public GameObject Alavanca1B;
    public GameObject Alavanca2B;
    public GameObject Alavanca3B;
    public GameObject Alavanca4B;
    public bool ativacao;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Poste3B.SetActive(false);
            Poste2B.SetActive(false);
            Poste1B.SetActive(false);
            Poste3A.SetActive(false);
            Poste2A.SetActive(false);
            Poste1A.SetActive(false);
            Poste5C.SetActive(false);
            Poste4C.SetActive(false);
            Poste3C.SetActive(false);
            Poste2C.SetActive(false);
            Poste1C.SetActive(false);
            Poste6D.SetActive(true);
            Poste5D.SetActive(true);
            Poste4D.SetActive(true);
            Poste3D.SetActive(true);
            Poste2D.SetActive(true);
            Poste1D.SetActive(true);
            Alavanca1B.SetActive(false);
            Alavanca2B.SetActive(false);
            Alavanca3B.SetActive(false);
            Alavanca4B.SetActive(true);
            Debug.Log("Encostou");
        }
    }
}