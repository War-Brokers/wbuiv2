using UnityEngine;

public class rotate : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0f, 0.5f, 0f);
    }
}
