using UnityEngine;

public class dance : MonoBehaviour
{

    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private float speed = 1f;
    [SerializeField] private int direction = 1;
    [SerializeField] private float radius = 5f;

    void Awake()
    {
    }
    void Update()
    {
        transform.Rotate(Vector3.up, speed * direction * Time.deltaTime);
        Transform cube = transform.Find("Cube");
        if (cube != null)
            cube.localPosition = radius * Vector3.forward;
            
    }
}
