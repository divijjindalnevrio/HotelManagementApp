using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InternetConnection : MonoBehaviour
{

    [SerializeField] private GameObject connectionLost;
    [SerializeField] private Button connectionButton;

    void Start()
    {
        InternetConnectionCheck();
    }

    private void Update()
    {
        if (Time.timeScale == 0)
        {
            Debug.Log("Trigger this function : ");
            connectionButton.onClick.AddListener(InternetConnectionCheck);
        }
    }

    public void InternetConnectionCheck()
    {
        Debug.Log("Error. InternetConnectionCheck : start");

        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            Debug.Log("Error. Check internet connection! : not working");
            connectionLost.SetActive(true);
            Time.timeScale = 0;

        }

        else
        {
            Debug.Log("Error. Check internet connection! : working");
            connectionLost.SetActive(false);
            Time.timeScale = 1;
        }
    }

}
