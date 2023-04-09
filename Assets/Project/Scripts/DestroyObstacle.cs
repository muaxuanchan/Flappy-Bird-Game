using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    [SerializeField] private float deletePosX;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deletePosX)
        {
            Destroy(gameObject);
        }
    }
}
