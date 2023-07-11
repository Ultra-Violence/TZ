using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private float _wallHeight = 1f;
    public float wallHeight => _wallHeight;

    public void DestroyObject(){
        Destroy(gameObject);
    }


}
