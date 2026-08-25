using UnityEngine;
using UnityEngine.InputSystem;

public class PoolGun : MonoBehaviour
{
    public PoolManager pool;
    public Transform firePoint;
    
    //Called by PlayerInput Invoke Unity Events for Fire action
    public void OnFire(InputAction.CallbackContext context)
    {
        if (!context.performed) return; //only on press or trigger

        GameObject bullet = pool.GetObject(); //reference the gameobject bullet in pool
        if (bullet == null) return; //if you cant get the bullet dont do anything (safety check)

        bullet.transform.SetPositionAndRotation(firePoint.position, firePoint.rotation);
        var rb = bullet.GetComponent<Rigidbody>();
        if (rb) rb.linearVelocity = firePoint.forward * 20f; //add force to push bullet forward
    }
}
