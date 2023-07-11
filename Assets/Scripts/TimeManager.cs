using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private GameObject playAgain;
    [SerializeField] private GameObject tapToPlay;
    [SerializeField] private PlayerCubeController playerCubeController;
    [SerializeField] private bool startedGame = false;


    private void Update() {
        if(playerCubeController.cubeNum < 0){
            playAgain.SetActive(true);
            startedGame = false;
        }
        
        if(Input.touchCount > 0 && startedGame == false && playAgain.activeInHierarchy == false){
            startedGame = true;
        }

        if(startedGame == true){
            Time.timeScale = 1;
            tapToPlay.SetActive(false);
        }
        else {
            Time.timeScale = 0;
        }
    }
}
