using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public void BackToMainMenu(){
        SceneManager.LoadScene(0);
    }
    // private CountDownTimer timer;
    // [SerializeField] TextMeshProUGUI m_Object;

    // m_Object.text = timer.currentTime.ToString("0");

}
