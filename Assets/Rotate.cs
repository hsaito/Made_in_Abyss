using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private GameObject _logo;
    // Start is called before the first frame update
    void Start()
    {
        _logo = GameObject.Find("MadeInAbyss");
    }

    // Update is called once per frame
    void Update()
    {
        _logo.transform.Rotate(0, 0, 0.2f, Space.Self);
    }
}
