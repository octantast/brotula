using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class scenechanger : MonoBehaviour
{
   // public VideoPlayer opening;
    private AsyncOperation asyncOperation;

    void Start()
    {
        //opening.Play();
        asyncOperation = SceneManager.LoadSceneAsync("GameScene");
        asyncOperation.allowSceneActivation = false;
    }

    void Update()
    {

        //if ((opening.frame) > 0 && (opening.isPlaying == false)) // когда видео закончилось
        //{
            Skip();
        //}
    }

    public void Skip()
    {
        asyncOperation.allowSceneActivation = true;
       // SceneManager.UnloadSceneAsync("Preloader");
    }
}
