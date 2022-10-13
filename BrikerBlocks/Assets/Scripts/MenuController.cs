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
        SceneManager.LoadScene("Fase");
    }

    public void QuiGame(){
     Application.Quit(); 
    }
}
