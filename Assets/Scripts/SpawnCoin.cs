using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject coinPrefab;

    public void SpawnCoins()
    {
        Instantiate(coinPrefab);
    }

    void Start()
    {
        SpawnCoins();
    }
}
