using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCubeController : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private GameObject collectCubeText;
    [SerializeField] private Animator animator;
    

    private float _cubeNum = 0;
    public float cubeNum => _cubeNum;

    public void AddCube()
    {
        Vector3 screenPos = Camera.main.WorldToViewportPoint(transform.position);

        Instantiate(cubePrefab, new Vector3(transform.position.x, transform.position.y - 0.5f - cubeNum, transform.position.z), Quaternion.identity, transform);
        Instantiate(collectCubeText, transform.position, Camera.main.GetComponent<Transform>().rotation);
        _cubeNum++;
        transform.position += Vector3.up;
        GetComponent<ParticleSystem>().Play(true);
        animator.Play("Jumping", 0, 0f);
    }

    
    public void RemoveCube( float WallHeight)
    {
        _cubeNum--;
        transform.position = new Vector3(transform.position.x, transform.position.y - WallHeight, transform.position.z);
    }

    
}
