using UnityEngine;

public class PlayerHitboxManagerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Collider[] attackColliders;
    void Start()
    {
        foreach(Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = false;
        }
    }

    public void EnableHitbox()
    {
        foreach (Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = true;
        }
    }

    public void DisableHitbox()
    {
        foreach (Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = false;
        }
    }

}
