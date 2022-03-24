using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeShow : MonoBehaviour {
    public Text time;
    private float tim;
    void Update() {
        tim += Time.deltaTime;
        time.text = "Earth Days Elapsed: " + Mathf.Floor(tim).ToString();    
    }
}
