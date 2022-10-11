using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContoladorCC : MonoBehaviour
{
    [SerializeField] private Transform ComtoladorGolpe;
    [SerializeField] private float radioGolpe;
    [SerializeField] private float dañogolpe;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Golpe();
        }
    }
    private void Golpe()
    {
        animator.SetTrigger("Golpe");

        Collider2D[] objetos = Physics2D.OverlapCircleAll(ComtoladorGolpe.position, radioGolpe);

        foreach (Collider2D colisionador in objetos)
        {
            if (colisionador.CompareTag("Enemigo"))
            {
                colisionador.transform.GetComponent<Enemigo>().TomarDaño(dañogolpe);
            }
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(ComtoladorGolpe.position, radioGolpe);
    }
}


