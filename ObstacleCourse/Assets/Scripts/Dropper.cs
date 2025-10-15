using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3.0f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.useGravity = false;
        myMeshRenderer.enabled = false;
    }
    void Update()
    {
        if (Time.time >= timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }
}
