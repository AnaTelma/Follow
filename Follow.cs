using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;
    private float cameraZ;
    void Start()
    {
        cameraZ = transform.position.z;
    }
    void Update()
    {
        transform.position = new Vector3(player.position.x + 0.5f, player.position.y + 0.5f, cameraZ);
    }
}