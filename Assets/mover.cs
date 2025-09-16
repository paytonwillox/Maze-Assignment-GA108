using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mover : MonoBehaviour
{
    public static mover Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        } else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {

    }

    void Update()
    {

    }

    public void sceneToMoveTo()
   {
       SceneManager.LoadScene("Scenes/SampleSample");
   }
}
