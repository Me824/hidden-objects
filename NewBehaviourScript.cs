using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    float count = 5;
    static float founds = 0;
    [SerializeField] GameObject Pobeda;
    [SerializeField] GameObject Porogenie;
    
    [SerializeField] TextMeshProUGUI time_text;
    [SerializeField] GameObject obj_text;
    void Start(){
        
    }

    void Update(){
        if(count > 0){
            count = count - Time.deltaTime;
            time_text.text = "Время: " + (Mathf.Round(count));
        }
        if(count <= 0){
            Debug.Log(founds);
            if(founds == 3){
                Debug.Log("Победа!");
                Pobeda.SetActive(true);
            }
            if(founds < 3){
                Debug.Log("Поражение...");
                Porogenie.SetActive(true);
            }
        }
    }
    void OnMouseDown(){
        gameObject.SetActive(false);
        obj_text.SetActive(false);
        founds = founds + 1;
    }

}