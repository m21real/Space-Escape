using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalCollectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreManager.score += 1;
        gameObject.SetActive(false);
    }
}
