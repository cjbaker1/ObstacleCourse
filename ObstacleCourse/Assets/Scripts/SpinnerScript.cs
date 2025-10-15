using UnityEngine;

public class SpinnerScript : MonoBehaviour
{
    [SerializeField] float rotateX = 0f;
    [SerializeField] float rotateY = 0f;
    [SerializeField] float rotateZ = 0f;
    void Start()
    {
    
    }

    void Update()
    {
    GetComponent<Transform>().Rotate(rotateX, rotateY, rotateZ);   
    }
}
