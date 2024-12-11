using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField, Tooltip("The Player Tag")] string playerTag;
    [SerializeField, Tooltip("Zombie speed")] float speed;
    [SerializeField, Tooltip("Rotation speed")] float rotationSpeed = 5f;

    public void atackThePlayer()
    {
        GameObject Player = GameObject.FindGameObjectWithTag(playerTag);
        if (Player != null)
        {
            Vector3 targetPosition = Player.transform.position;
            Vector3 direction = (targetPosition - transform.position).normalized;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion lookRotation = Quaternion.Euler(0, 0, angle);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);

            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }
}
