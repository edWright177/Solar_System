using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {
    public GameObject parent; //parent to orbit around
    public float velocity;
    private void Update() {
        OrbitAround();
    }
    void OrbitAround() {
        transform.RotateAround(parent.transform.position, Vector3.up, velocity * Time.deltaTime);
    }

}
