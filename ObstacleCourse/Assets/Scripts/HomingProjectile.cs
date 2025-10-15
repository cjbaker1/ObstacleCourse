using UnityEngine;

public class HomingProjectile : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float projectileSpeed = 25f;
    Vector3 playerPosition;
    void Start()
    {
        playerPosition = player.transform.position; 
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime*projectileSpeed);    
    }
}
