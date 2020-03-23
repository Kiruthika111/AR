using UnityEngine;
using System.Collections;

public class EarthSpinScript : MonoBehaviour {
    

    void Update() {
        transform.Rotate(new Vector3(0f, 1f, 0f));
    }
}