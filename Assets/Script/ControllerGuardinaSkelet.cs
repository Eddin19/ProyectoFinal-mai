using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGuardinaSkelet : MonoBehaviour
{
    private Rigidbody2D rb;
    Animator animator;
    private int currentAnimation = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //hacer algo cuando el personaje recien llegue activar animacion de atacar
        //if
        currentAnimation = 3;
        //cuando se acerque el personaje ejecutar la animacion de ataque  currentAnimation = 2;
        animator.SetInteger("Estado", currentAnimation);
    }
}
