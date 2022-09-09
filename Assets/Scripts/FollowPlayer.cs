using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform player;
    private Vector3 offset;
    private void Update()
    {
        transform.position = player.position + offset;
    }
}
