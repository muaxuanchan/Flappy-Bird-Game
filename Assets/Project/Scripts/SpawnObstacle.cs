using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject obstacle;
    public Sprite[] pipeSprites;

    private int index;
    [SerializeField] private float spawnPositionX;
    [SerializeField] private float startDelay;
    [SerializeField] private float spawnTime;
    [SerializeField] private float rangePosY;

    private void Awake()
    {
        index = Random.Range(0, pipeSprites.Length);
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, spawnTime);
    }

    void SpawnObstacles()
    {
        rangePosY = Random.Range(-1.5f, 1.5f);

        obstacle.GetComponentsInChildren<SpriteRenderer>()[0].sprite = pipeSprites[index];
        obstacle.GetComponentsInChildren<SpriteRenderer>()[1].sprite = pipeSprites[index];
        Instantiate(obstacle, new Vector3(spawnPositionX, rangePosY, 0f), obstacle.transform.rotation);
    }
}
