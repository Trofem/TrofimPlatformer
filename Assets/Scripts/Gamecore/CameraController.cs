using UnityEngine;
public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float x;
    [SerializeField] private float y;
    private void Update()
    {
        transform.position = new Vector2(player.position.x + x, player.position.y + y);
    }
}
