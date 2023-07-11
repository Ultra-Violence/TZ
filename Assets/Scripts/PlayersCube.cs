using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersCube : MonoBehaviour
{
    [SerializeField] private PlayerCubeController playerCubeController;

    private void Start() {
        playerCubeController = gameObject.GetComponentInParent<PlayerCubeController>();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "PickUpCube"){
            playerCubeController.AddCube();
        }
        else if(other.tag == "Wall"){
            playerCubeController.RemoveCube(other.GetComponent<Wall>().wallHeight);
            other.GetComponent<Wall>().DestroyObject();
            Destroy(gameObject);
        }
    }

    private void Update() {
        
    }
}