﻿using UnityEngine;

public class PowerUpJump : PowerUp
{
    public float spawnChance;
    public static bool collected;

    protected override void Start()
    {
        collected = false;
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    public override void SpawnIfAvailable(Bounds bounds)
    {
        if (collected || spawnChance <= Random.Range(0f, 100f))
        {
            return;
        }

        base.SpawnIfAvailable(bounds);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Collect();
    }

    public void Collect()
    {
        Debug.Log("Jump power up collected, prepare to get rekt!");
        gameObject.SetActive(false);

        collected = true;
    }
}
