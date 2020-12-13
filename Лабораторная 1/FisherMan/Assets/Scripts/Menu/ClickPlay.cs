using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickPlay : MonoBehaviour {

    public GameObject bttn;
    public GameObject PlayerWithAnim;
    public Text playTxt, gameName;
    
    private void OnMouseDown()
    {
        gameName.GetComponent<Scroll>().speed = 5;
        gameName.GetComponent<Scroll>().checkPos = 400;

        bttn.GetComponent<Scroll>().speed = -10;
        bttn.GetComponent<Scroll>().checkPos = -400;

        playTxt.gameObject.SetActive(false);

        PlayerWithAnim.GetComponent<Animation>().Play("WalkToMountain");
        Invoke("InvokeScene", 2f);
        
    }
    private void InvokeScene()
    {
        SceneManager.LoadScene(0);
    }

}