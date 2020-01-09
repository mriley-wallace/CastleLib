using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[System.Serializable]
public class OnDamagedEventPlayer : UnityEvent<int> { }
public class HealthSystemPlayer : MonoBehaviour
{
    public int health = 10;
    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;
    public void TakeDamage(int damage)
    {
        health -= damage;
        onDamaged.Invoke(health);
        if (health < 1)
        {
            onDie.Invoke();
            SceneManager.LoadScene("GameOver");
        }

        if (health > 100)
        {
            health = 100;
        }
    }
}