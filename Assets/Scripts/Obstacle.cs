using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private void FixedUpdate() {
        if(transform.position.y < 0){
            transform.position += Vector3.up * Time.fixedDeltaTime * 100f;
        }
    }
}
