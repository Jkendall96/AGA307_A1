using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public EnemyType type;


    // Start is called before the first frame update
    void Start()
    {
        if (type == EnemyType.Archer)
            health = 50;
        else if (type == EnemyType.OneHanded)
            health = 100;
        else if (type == EnemyType.TwoHanded)
            health = 150;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
            Hit(5);
    }

    void Hit(int DMG)
    {
        GameManager.instance.AddScore(5);

        health -= DMG;
        if (health <= 0)
            Die();

    }
    void Die()
    {
        GameManager.instance.AddScore(5);
        StopAllCoroutines();
        Destroy(this.gameObject);
    }
}

public enum EnemyType
{
    Archer,
    OneHanded,
    TwoHanded
}
