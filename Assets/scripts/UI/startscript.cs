using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class startscript : MonoBehaviour
{
    public Button startbutton;

    void Start()
    {
        Button btn = startscript.GetComponent <button> ();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("Alix Scene");
    }
}