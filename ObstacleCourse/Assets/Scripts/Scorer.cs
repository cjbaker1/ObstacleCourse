using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You've bumpted into an obstalce " + hits + " times!");
        }    
    }
    
    
}
