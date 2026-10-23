using System;
using TMPro;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public GameObject Cystal;
    public GameObject Robot;
    public GameSystem instance;
    public TextMeshPro ScoreText;
    public int points = 0;
    public int reward = 50;
    public int punishment = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = GetComponent<GameSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (GetKeyDown("w"))
        //{

        //}
        //if (GetKeyDown("a"))
        //{

        //}
        //if (GetKeyDown("s"))
        //{

        //}
        //if (GetKeyDown("d"))
        //{

        //}
        InvokeRepeating("SpawnCrystals", 0, 2);
        InvokeRepeating("SpawnRobots", 0, 3);
        // InvokeRepeating(nameof(SpawnCrystals(), 0, 3);
        // InvokeRepeating(nameof(SpawnRobots(), 0, 3);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetType() != Type.GetType("Collectable") || collision.gameObject.GetType() == Type.GetType("Enemy"))
        {
            return;
        }

        if (collision.gameObject.GetType() == Type.GetType("Collectable"))
        {
            AddPoints();
        }

        if (collision.gameObject.GetType() == Type.GetType("Enemy"))
        {
            RemovePoints();
        }

        Destroy(collision.gameObject);
    }

    private void AddPoints()
    {
        points += reward;
        
    }

    private void RemovePoints()
    {
        points -= punishment;

    }

    private void UpdateScore()
    {
        //ScoreText = TextMeshPro.("Score: " + points);
    }

    private void ResetGame()
    {
        
    }

    public void SpawnCrystals()
    {
        GameObject.Instantiate(Cystal);
    }

    private void SpawnRobots()
    {
        GameObject.Instantiate(Robot);
    }
}
