using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chuyencanh4 : MonoBehaviour
{
    [SerializeField] Animator loadScence;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(12);
           
        }

    }
}