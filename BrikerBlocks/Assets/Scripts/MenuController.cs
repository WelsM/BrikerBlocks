using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject Credits;
    public GameObject Op;

    private void Awake() {
        Credits.SetActive(false);
        Op.SetActive(false);
    }
    public void PlayGame(){
     Debug.Log("PlayGame!");   
    }

    public void QuiGame(){
     Debug.Log("Quit!");   
    }
    
    public void PlayCredits(){
     Debug.Log("Credits!");
    }

    public void Options(){
     Debug.Log("Options!");  
    }

    public void ReturnMenu(){
     Debug.Log("ReturnMenu!");  
    }
}
