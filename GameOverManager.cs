using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverManager : MonoBehaviour
{
    public void Retry()
    {
        // เปลี่ยนไปยัง Sample Scene
        SceneManager.LoadScene("SampleScene"); 
    }
}