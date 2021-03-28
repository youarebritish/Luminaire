using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_main_Environment : MonoBehaviour
{
    void Start()
    {
        Scene newScene = SceneManager.CreateScene("Menu_main_Environment");
        SceneManager.LoadScene("Menu_main_Environment", LoadSceneMode.Single);
    }

    void Update()
    {

    }
}