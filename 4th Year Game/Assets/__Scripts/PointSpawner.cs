using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities;
// spawn enemies at different spawn points

public class PointSpawner : MonoBehaviour
{
    
    // == Private fields ==
    // need a prefab to spawn 
    [SerializeField]
    private GameObject blockPrefab;

    [SerializeField]
    private float spawnDelay = 20.0f;   //  delay at the beginning of game

    [SerializeField]
    private float spawnInterval = 1.5f; //  delay after eachother

    private IList<SpawnPoint> spawnPoints;

    // rather than a random selection from the list, 
    // set up a stack of random numbers, then pop from the stack
    // until the stack is empty.
    private Stack<SpawnPoint> spawnStack;

    // create a variable for the parent object of enemies.
    // name that "EnemyParent"
    private GameObject blockParent;

    // Start is called before the first frame update
    void Start()
    {
        // get the enemy parent object
        blockParent = ParentUtils.GetBlockParent();

        // need to get a list of spawn points
        spawnPoints = GetComponentsInChildren<SpawnPoint>();
        SpawnRepeating();
    }

    // invokeRepeating
    private void SpawnRepeating()
    {
        // create the stack
        // create the method in a Utils class
        spawnStack = ListUtils.CreateShuffledStack(spawnPoints);
        InvokeRepeating("Spawn", spawnDelay, spawnInterval);
    }

    // spawn a single enemy ship
    private void Spawn()
    {
        //var randomIndex = Random.Range(0, spawnPoints.Count);
        //var currPoint = spawnPoints[randomIndex];
        if(spawnStack.Count == 0)
        {
            // reshuffle the stack again
            spawnStack = ListUtils.CreateShuffledStack(spawnPoints);
        }
        var spawnPoint = spawnStack.Pop();

        //var enemy = Instantiate(enemyPrefab); // add to the hierarchy base level
        var block = Instantiate(blockPrefab, blockParent.transform);
        block.transform.position = spawnPoint.transform.position;
    }

}
