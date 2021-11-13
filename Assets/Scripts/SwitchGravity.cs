using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGravity : MonoBehaviour
{
    [SerializeField] private Rigidbody2D body;

    //private bool top;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            // Activates anti-gravity for the player
            body.gravityScale *= -1;
            Debug.Log("Anti-Gravity enabled");
        }
    }

    /*
    private void Rotation()
    {

    }
    */
}
