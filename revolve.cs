using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revolve : MonoBehaviour
{
    public GameObject orbitAround;
    // Start is called before the first frame update
    void Start()
    {
        orbitAround=GameObject.Find("sun");
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(orbitAround.transform.position,Vector3.down,0.3f);
    }
}
