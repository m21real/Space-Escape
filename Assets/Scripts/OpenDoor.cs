using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private bool playerDetected;
    public Transform doorPos; // Gets the position of the door in the scene
    public float width; // Adjust the door collider field in Unity editor
    public float height;

    public LayerMask whatIsPlayer;

    [SerializeField] private string sceneName;

    SceneSwitch sceneSwitch;

    private void Start()
    {
        sceneSwitch = FindObjectOfType<SceneSwitch>();
    }

    private void Update()
    {
        playerDetected = Physics2D.OverlapBox(doorPos.position, new Vector2(width, height), 0, whatIsPlayer);

        if (playerDetected == true)
        {
            if (Input.GetKeyDown(KeyCode.E)) // Detects if player presses "E" when in the box collider / doorway
            {
                Debug.Log("Player entering room...");
                sceneSwitch.SwitchScene(sceneName);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(doorPos.position, new Vector3(width, height, 1));
    }
}
