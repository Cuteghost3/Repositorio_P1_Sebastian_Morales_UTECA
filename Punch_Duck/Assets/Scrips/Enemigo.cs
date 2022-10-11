using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float maximoVida;
    [SerializeField] private BarradeVida barradeVida;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();

        vida = maximoVida;
        barradeVida.InicializarBarraDeVida(vida);
    }

    public void TomarDa�o(float da�o)
    {
        vida -= da�o;
        barradeVida.CambiarVidaActual(vida);

        if (vida <=0)
        {
            Muerte();
        }
    }

    private void Muerte()
    {
        animator.SetTrigger("Muerte");
    }
}
