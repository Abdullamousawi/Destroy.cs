using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField]
    [Min(0.1f)]
    float time = 10f;

    private void Start()
    {
        Destroy(gameObject, time);
    }
}
