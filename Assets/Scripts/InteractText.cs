using UnityEngine;

public class InteractText : MonoBehaviour
{
    private void Update()
    {   
        //Text on canvas will follow the player as they walk
        Quaternion rotation = Camera.main.transform.rotation;
        transform.LookAt(worldPosition:transform.position + rotation * Vector3.forward, worldUp:rotation * Vector3.up);
    }
}
