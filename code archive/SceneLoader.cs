using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame updat

    public void LoadLevel1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    //public void LoadSettings("settings")
    //{

    //    }

}
