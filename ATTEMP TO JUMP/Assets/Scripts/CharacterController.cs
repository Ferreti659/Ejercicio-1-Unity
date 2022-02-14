using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Rigidbody2D rigibody;
    public float velocidad;
    private bool mirandoDerecha = true;
    public float fuerzaSalto;
    public bool CanMove = true;
    private BoxCollider2D boxCollider;
    public LayerMask capaSuelo;
    private Animator animator;


    /*public bool isGrounded;
    public bool canJump = true;
    public float jumpValue 0.0f;*/

    private void Start()
    {
        rigibody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //ProcesarMovimiento();

        /*isGrounded = Physics.OverlapBox(new Vector2(gameObject.transform.x, gameObject.transform.y - 0.5f),
                new Vector2(0.9f, 0, 4f), 0f, groundMask);

        if (Input.GetKey("space") && isGrounded && canJump)
        {
            jumpValue += 0.1f;
        }*/
        ProcesarSalto();
    }

    void FixedUpdate()
    {
        if (CanMove == true)
        {
            ProcesarMovimiento();
        }
        else
        {
            CanMove = false;
        }

        if (Input.GetKey(KeyCode.Space) && JumpCharge <= 75 && EstaEnSuelo == true)
        {
            JumpCharge++;
        }
    }

    bool EstaEnSuelo()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center,
                        new Vector2(boxCollider.bounds.size.x, boxCollider.bounds.size.y),
                        0f, Vector2.down, 0.2f, capaSuelo);

        return raycastHit.collider != null;
    }

    void ProcesarSalto()
    {

        fuerzaSalto = 0;


        if (Input.GetKey(KeyCode.space) && JumpCharge <= 75 && EstaEnSuelo)
        {
            JumpCharge++;
        }

        if (CanMove == true)
        {
            ProcesarMovimiento();
        }

        if (EstaEnSuelo = Physics2D.overlapCircle(feetPos.position, checkRadius, whatIsGround))
        {
            IsJumping = false;
        }
        else
        {
            IsJumping = true;
        }

        if(IsJumping == true || Input.GetKey(KeyCode.Space))
        {
            CanMove = false;
        }
        else
        {
            CanMove = true;
        }

        if (EstaEnSuelo == true && Input.GetKeyUp(KeyCode.space && NormalJump == true))
        {
            rigibody.velocity = Vector2.up * fuerzaSalto * JumpCharge / 35;
            if (isJumping == false)
            {
                JumpCharge = 1;
            }
            IsJumping = true;
            NormalJump = true;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            NormalJump = false;
        }
        else
        {
            NormalJump = true;
        }

        if (EstaEnSuelo == true && Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.space))
        {
            rigibody.velocity = Vector2.up * fuerzaSalto * JumpCharge / 35;
            JumpCharge = 1;
            IsJumping = true;

        }

        if (EstaEnSuelo == true && Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.space))
        {
            rigibody.velocity = Vector2.up * fuerzaSalto * JumpCharge / 35;
            JumpCharge = 1;
            IsJumping = true;

        }
    }




    void ProcesarMovimiento(){
        

            float inputMovimiento = Input.GetAxis("Horizontal");
            rigibody.velocity = new Vector2(inputMovimiento * velocidad, rigibody.velocity.y);
            GestionarOrientacion(inputMovimiento);

            if (inputMovimiento != 0f)
            {
                animator.SetBool("isrunning", true);
            }
            else
            {
                animator.SetBool("isrunning", false);
            }
        
    }

    void GestionarOrientacion(float inputMovimiento)
    {

        if( (mirandoDerecha == true && inputMovimiento < 0) || (mirandoDerecha == false && inputMovimiento > 0))
        {
            mirandoDerecha = !mirandoDerecha;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }

    }

}
