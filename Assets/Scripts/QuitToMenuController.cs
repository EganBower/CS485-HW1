﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class QuitToMenuController : MonoBehaviour
{

    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
}


