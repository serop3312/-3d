using UnityEngine;

public class TreeChopper : MonoBehaviour
{
    public float chopForce = 100f;
    public GameObject treeFallEffect;
    private Rigidbody treeRb;
    private bool isChopped = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Axe") && !isChopped)
        {
            treeRb = GetComponent<Rigidbody>();
            treeRb.constraints = RigidbodyConstraints.None;
            treeRb.AddForce(transform.up * chopForce, ForceMode.Impulse);
            isChopped = true;
            Instantiate(treeFallEffect, transform.position, Quaternion.identity);
            Destroy(gameObject, 3f);
        }
    }
}
