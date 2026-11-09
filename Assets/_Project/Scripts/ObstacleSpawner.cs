using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;

    void Start()
    {
        StartCoroutine(nameof(SpawnObstacle));
    }

    private IEnumerator SpawnObstacle()
    {
        yield return new WaitForSeconds(1);
        Instantiate(obstacle, Vector3.right * 5, Quaternion.identity);
        StartCoroutine(nameof(SpawnObstacle));
    }
}
