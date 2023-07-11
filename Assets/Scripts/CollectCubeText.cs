using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCubeText : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    void Start()
    {
        Invoke("DestroyObj", 2f);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.up * Time.fixedDeltaTime * speed;
    }

    private void DestroyObj(){
        Destroy(gameObject);
    }
}
