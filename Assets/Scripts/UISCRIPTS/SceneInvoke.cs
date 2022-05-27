using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneInvoke : MonoBehaviour
{

    public int _SceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(_SceneIndex));

    }

}
