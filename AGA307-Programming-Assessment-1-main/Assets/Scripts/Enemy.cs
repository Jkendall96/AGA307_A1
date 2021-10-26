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
        else if (enemyType == EnemyType.OneHanded)
            health = 100;
        else if (enemyType == EnemyType.TwoHanded)
            health = 150;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum EnemyType
{
    Archer,
    OneHanded,
    TwoHanded
}
