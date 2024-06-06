using UnityEngine;

public class Rotate : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0f, 0.5f, 0f);
    }
}
