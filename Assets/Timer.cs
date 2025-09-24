using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public float Timer = 30;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        Text.text = "Time: " + Mathf.Round(Timer);
        if (Timer <= 0)
        { 
            Debug.Log("TIMES UP!");
        }
    }
}
