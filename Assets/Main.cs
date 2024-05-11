using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField] Button _test1Button;
    [SerializeField] Button _test2Button;
        
    void Start()
    {
        _test1Button.onClick.AddListener(() => SceneManager.LoadScene("Test1Scene"));
        _test2Button.onClick.AddListener(() => SceneManager.LoadScene("Test2Scene"));
    }
}
