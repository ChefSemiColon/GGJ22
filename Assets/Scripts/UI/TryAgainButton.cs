using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TryAgainButton : MonoBehaviour
{
    public Button restartButton;
    void Start()
    {
        //listen to see if the button will be clicked
        restartButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Load the main scene
        SceneManager.LoadScene(1);
    }
}
