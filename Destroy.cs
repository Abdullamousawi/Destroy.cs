using UnityEngine;
// https://www.mousawi.dev/codes by @AbdullaMousawi
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
