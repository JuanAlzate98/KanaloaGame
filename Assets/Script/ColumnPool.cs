    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public int ColumnPoolSize = 5;
    public GameObject columnPrefab;
    private GameObject[] columns;
    private Vector2 ObjectPoolPosition = new Vector2(-14, -0.7f);
    private float timeSinceLastSpawned;
    public float spawnRate;
    public float columnMin = -1f;
    public float columnMax =  3.8f;
    private float spawnXPosition = 10f;
    private int currentColumn;
    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[ColumnPoolSize];
        for (int i = 0; i < ColumnPoolSize; i++)
        {
            columns[i] = Instantiate(columnPrefab, ObjectPoolPosition, Quaternion.identity);
        }
        SpawnColumn();
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if(!GameController.instance.Gameover && timeSinceLastSpawned>=spawnRate)
        {
            timeSinceLastSpawned = 0;
            SpawnColumn();
        }
    }
    void SpawnColumn()
    {
        float spawnYPosition = Random.Range(columnMin, columnMax);
        columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);
        currentColumn++;
        if (currentColumn >= ColumnPoolSize)
        {
            currentColumn = 0;
        }
    }
}
