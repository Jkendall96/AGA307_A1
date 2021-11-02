using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameState
{
    Start,
    Play,
    Pause,
    GameOver
}


public class GameManager : Singleton<GameManager>
{

    public int score;
    public int scoreMultiplier;
    public GameState state;

    protected override void Awake()
    {
        base.Awake();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int toAdd)
    {
        score += toAdd;
    }

}
