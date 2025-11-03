using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float speed = 2.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
    }
}
