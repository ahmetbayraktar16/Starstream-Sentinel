using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Wave Config", fileName = "New Wave Config")]
public class WaveConfigSO : ScriptableObject
{
    [SerializeField] List<GameObject> enemyPrefab;
    [SerializeField] Transform pathPrefab;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float timeBetweenEnemySpawns = 1f;
    [SerializeField] float spawnTimeVariance = 0.5f;
    [SerializeField] float minSpawnTime = 0.2f;

    public Transform GetStartingWayPoint()
    {
        return pathPrefab.GetChild(0);
    }
    public int GetEnemyCount()
    {
        return enemyPrefab.Count;
    }

    public GameObject GetEnemyPrefab(int index)
    {
        return enemyPrefab[index];
    }
    public List<Transform> GetWayPoints()
    {
        List<Transform> wayPoints = new List<Transform>();
        foreach (Transform child in pathPrefab)
        {
            wayPoints.Add(child);
        }
        return wayPoints;
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

    public float GetRandomSpawnTime()
    {
        float spawnTime = Random.Range(timeBetweenEnemySpawns - spawnTimeVariance, timeBetweenEnemySpawns + spawnTimeVariance);
        return Mathf.Clamp(spawnTime, minSpawnTime, float.MaxValue);
    }
}