using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 60;

    [SerializeField] TextMeshProUGUI m_Object;

    void Start(){
        currentTime = startingTime;
    }
    void Update(){

            currentTime -= Time.deltaTime;
            m_Object.text = currentTime.ToString("0");

            if (currentTime <= 0){
                currentTime = 0;
                SceneManager.LoadScene(0);
            }
        }
    }
