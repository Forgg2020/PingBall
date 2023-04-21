using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    private bool CanCreate;
    public GameObject BallPrefab;
    public GameObject Player;
    private SphereCollider Ballcol;
    Rigidbody rb;

    private void Start()
    {
        
    }
    public void Update()
    {
        Player.GetComponent<Player>().OnDeathEvent += OnPlyaerDeath;
    }

    public void OnPlyaerDeath()
    {
        if (!CanCreate)
        {
            Destroy(gameObject);
            Instantiate(BallPrefab, new Vector3(4.2f, -2.5f, -0.1f), new Quaternion(0, 0, 0, 0));
            //Ballcol = Player.GetComponent<SphereCollider>();
            Debug.Log("death");
            rb = Player.GetComponent<Rigidbody>();
            CanCreate = true;
            //SceneManager.LoadScene(0);
        }
    }
}
