using UnityEngine;

public class HomingProjectile : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float projectileSpeed = 25f;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        if (gameObject.activeSelf == true)
        {
            moveToPlayer();
            DestroyWhenReached();
        }
    }
    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
    //Methods
    void moveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * projectileSpeed);
    }
    
}
