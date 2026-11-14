using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    [SerializeField] private float range = 2;
    [SerializeField] private float positionX = 5;

    void Start()
    {
        StartCoroutine(nameof(SpawnObstacle));
    }

    private IEnumerator SpawnObstacle()
    {
        yield return new WaitForSeconds(1);
        var positionY = Random.Range(-2f, 2f);
        var spawnPosition = new Vector3(positionX, positionY, 0);

        Instantiate(obstacle, spawnPosition, Quaternion.identity);
        StartCoroutine(nameof(SpawnObstacle));
    }
}
