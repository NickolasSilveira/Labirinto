using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (FindObjectOfType<GameManager>().possuiChave == true)
            {
                
                UnityEngine.Debug.Log("A porta foi aberta");
                anim.SetBool("PossuiChave", true);
            }
            else
            {
                UnityEngine.Debug.Log("Ache a chave");
            }
        }
    }
}
