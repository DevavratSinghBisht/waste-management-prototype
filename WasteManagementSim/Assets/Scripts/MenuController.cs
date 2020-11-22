using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject eWasteButton;
    public GameObject wasteMarketButton;


    //loads the home scene
    public void Home(){
        SceneManager.LoadScene("Home");
    }

    //loads the segregate scene
    public void Segregate()
    {
        SceneManager.LoadScene("Segregate");
    }

    // loads the waste market scene
    public void WasteMarket()
    {
        SceneManager.LoadScene("WasteMarket");
    }

    public void Camera()
    {
        eWasteButton.SetActive(true);
        wasteMarketButton.SetActive(true);
    }

    public void EWasteData()
    {
        SceneManager.LoadScene("EWasteData");
    }

    public void Contribute()
    {
        SceneManager.LoadScene("Contribute");
    }

    public void Search()
    {
        SceneManager.LoadScene("Search");
    }

    public void WasteAdded()
    {
        SceneManager.LoadScene("WasteAdded");
    }

}
