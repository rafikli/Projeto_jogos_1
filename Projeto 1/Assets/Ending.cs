using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Ending : MonoBehaviour
{
    private CountDownTimer timer;
    [SerializeField] TextMeshProUGUI m_Object;
    private void OnTriggerEnter2D ( Collider2D other )
    
    {
        Debug.Log ( " Hit : " );
        // m_Object.text = timer.currentTime.ToString("0");
        SceneManager.LoadScene(3);
    }
}
