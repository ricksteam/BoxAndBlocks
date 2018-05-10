using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    public GameObject blockPrefab;
    public int numOfBlocks;         //goal number of total blocks (150)
    public int blockInterval;       //number of blocks to start out with
    public GameObject otherSpawnPoint;

    private int currBlocks = 0;     //count of blocks spawned
    private static List<GameObject> spawnedBlocks = new List<GameObject>();

    void SpawnBlock()
    {
        spawnedBlocks.Add(Instantiate(blockPrefab, this.transform.position + new Vector3(Random.Range(-.2f, .2f), 0, Random.Range(-.2f, .2f)), Quaternion.identity));
        currBlocks++;
        if (currBlocks % blockInterval == 0)
            CancelInvoke();
    }

    //when a block is placed on the goal side of the box, a new block will be spawned to replace it on the start side
    public void DecrementBlocks()
    {
        SpawnBlock();
    }

    public static List<GameObject> GetSpawnedBlocks()
    {
        return spawnedBlocks;
    }

    public void StartSpawning(int grabbableLayer)
    {
        blockPrefab.layer = grabbableLayer;
        blockPrefab.GetComponent<BlockStateChange>().spawnblocks = gameObject;
        blockPrefab.GetComponent<BlockStateChange>().goalSide = otherSpawnPoint;
        //spawn the block and wait before spawning another, 
        //to avoid block collisions and strange behavior before landing in box
        InvokeRepeating("SpawnBlock", 0, 0.1f);
    }
}
