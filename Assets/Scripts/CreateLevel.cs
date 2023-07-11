using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLevel : MonoBehaviour
{
    [SerializeField] private List<GameObject> obstacleList;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            Instantiate(obstacleList[Random.Range(0, obstacleList.Count)], new Vector3(transform.position.x, transform.position.y - 100f, transform.position.z + 60f), Quaternion.identity);
        }
    }
}
