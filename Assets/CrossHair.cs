using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrossHair : MonoBehaviour
{
    [SerializeField]
    JoyconDemo con;

    Image crosshair;
    // Update is called once per frame
    void Update()
    {
       // crosshair.rectTransform.position = new Vector3((con.gyro.x)*, 0);
    }
}
