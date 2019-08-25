using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{

    [HideInInspector] public float horizontal;
    [HideInInspector] public float vertical;
    [HideInInspector] public bool attack;
    [HideInInspector] public bool ability1;
    [HideInInspector] public bool ability2;
    [HideInInspector] public bool inventory;
    [HideInInspector] public bool interact;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        #region Debug
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        attack = Input.GetButtonDown("Attack");
        ability1 = Input.GetButtonDown("Ability1");
        ability2 = Input.GetButtonDown("Ability2");
        inventory = Input.GetButtonDown("Inventory");
        interact = Input.GetButtonDown("Interact");

        if (attack == true)
        {
            Debug.Log("Ataque " + "Activado");
        }

        if (ability1 == true)
        {
            Debug.Log("Habilidad 1 " + "Activada");
        }

        if (ability2 == true)
        {
            Debug.Log("Habilidad 2 " + "Activada");
        }

        if (inventory == true)
        {
            Debug.Log("Inventario " + "Activado");
        }

        if (interact == true)
        {
            Debug.Log("Interacción " + "Activada");
        }
        #endregion
    }
}
