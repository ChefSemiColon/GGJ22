using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RestartButton : MonoBehaviour
{
    public Button restartButton;
    private float timer = 0.5f;
    void Start()
    {
        //listen to see if the button will be clicked
        restartButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {



        while (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        SceneManager.LoadScene(1);
    }
}
