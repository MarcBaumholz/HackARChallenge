using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  MagicLeap.Examples;

public class clickableObject : MonoBehaviour
{
    public GameObject redBall;
    public GameObject greyBall;

    //RaycastHit hitData;
    //GameObject hitObject = hitData.transform.gameObject;

    public void onClick()
    {
        greyBall.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        greyBall.SetActive(false);// init
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
