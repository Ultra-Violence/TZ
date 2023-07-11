using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainBtn : MonoBehaviour
{
    public void PlayAgainButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
