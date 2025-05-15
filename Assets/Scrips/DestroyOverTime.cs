using UnityEngine;

public class DestroyOverTime : MonoBehaviour
{
    [Header("Variables")]
    public float tiemporVida = 1.2f;

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, tiemporVida);
    }
}
