using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class characterHealth : MonoBehaviour {
    public static int maxHealth = 10;
    public static int currentHealth;


    void Start () {

        currentHealth = maxHealth;

    }
    public static void onHit(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
