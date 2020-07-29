using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField]
    [Min(0.1f)]
    float time = 10f;

    private void Update()
    {
        Destroy(gameObject, time);
    }

}
