using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Shapes")]
    public GameObject[] shapes;
    public float minTimeToSpawn;
    public float maxTimeToSpawn;

    [Header("Walls")]
    public GameObject walls;

    private bool isWallsDown = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SpawnOneShape();
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            ToggleWalls();
        }
    }

    private void SpawnOneShape()
    {
        float spawnWaitTime = Random.Range(minTimeToSpawn, maxTimeToSpawn);

        if (shapes != null && shapes.Length > 0)
        {
            int randomIndex = Random.Range(0, shapes.Length);
            GameObject shapeClone = Instantiate(shapes[randomIndex]);
        }
    }

    private void ToggleWalls()
    {
        if (!isWallsDown)
        {
            walls.SetActive(false);
            isWallsDown = true;
        }
        else if (isWallsDown)
        {
            walls.SetActive(true);
            isWallsDown = false;
        }
    }
}
