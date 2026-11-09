using TMPro;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float speed = 3;
    [SerializeField] private TextMeshProUGUI label;
    private Transform tr;

    private void Awake()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tr.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
    }
}
