using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private InputPlayer playerInput;
    private Transform playerTransform;
    private float playerSpeed = 3;
    private float playerHorizontal;
    private float playerVertical;
    private Rigidbody2D playerRigidBody;

    // Configurar Animación
    private bool playerBack;
    private Animator playerAnimator;
    private SpriteRenderer playerSprite;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<InputPlayer>();
        playerTransform = GetComponent<Transform>();
        playerRigidBody = GetComponent<Rigidbody2D>();

        // Configurar Animación
        playerAnimator = GetComponent<Animator>();
        playerSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {

        playerHorizontal = playerInput.horizontal;
        playerVertical = playerInput.vertical;

        // Configurar Animación
        playerBack = (playerVertical > 0);

        AnimationPlayerSprite();

        if (playerHorizontal != 0 || playerVertical != 0)
        {
            //playerAnimator.SetBool("Back", playerBack);
            SetXYAnimator();
        }

    }

    private void AnimationPlayerSprite()
    {
        if (playerHorizontal < 0 && Mathf.Abs(playerVertical) < Mathf.Abs(playerHorizontal))
        {
            playerSprite.flipX = true;
        }
        else if (playerHorizontal != 0)
        {
            playerSprite.flipX = false;
        }
    }

    private void SetXYAnimator()
    {
        playerAnimator.SetFloat("X", playerHorizontal);
        playerAnimator.SetFloat("Y", playerVertical);
    }

    void FixedUpdate()
    {

        // Movimiento del Personaje Versión 1
        //Vector2 newPlayerPosition = transformplayer.position + new Vector3(speedplayer * horizontalplayer * Time.deltaTime, speedplayer * verticalplayer * Time.deltaTime, 0);
        //transformplayer.position = newPlayerPosition;

        // Movimiento del Personaje Versión 2
        //Vector2 forceplayer = new Vector2(playerHorizontal, playerVertical) * playerSpeed * Time.deltaTime;
        //playerRigidBody.AddForce(forceplayer);

        // Movimiento del Personaje Versión 3
        Vector2 forceplayer = new Vector2(playerHorizontal, playerVertical) * playerSpeed;
        playerRigidBody.velocity = forceplayer;


        #region Debug
        if (playerInput.attack == true)
        {
            Debug.Log("Jugador Atacando");
        }

        if (playerVertical != 0)
        {
            Debug.Log("Jugador de Espaldas");
        }
        #endregion
    }

}
