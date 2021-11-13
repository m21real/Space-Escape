using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiGravityEnable : MonoBehaviour
{
    private bool playerDetected;
    public Transform leverPos;
    public float width;
    public float height;

    public LayerMask whatIsPlayer;

    private void Update()
    {
        playerDetected = Physics2D.OverlapBox(leverPos.position, new Vector2(width, height), 0, whatIsPlayer);

        if (playerDetected == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log("Anti-Gravity enabled");
                Physics.gravity *= -1;
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(leverPos.position, new Vector3(width, height, 1));
    }
}
