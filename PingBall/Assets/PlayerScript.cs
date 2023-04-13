using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    [Header("Ãö¥d")]
    public GameObject PlayerBall;
    public int score;
    public void OncOnCollisionEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Space"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
