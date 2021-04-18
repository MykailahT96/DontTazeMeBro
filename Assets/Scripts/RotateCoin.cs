using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float spinSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, (spinSpeed * Time.deltaTime), 0f);
    }
}
