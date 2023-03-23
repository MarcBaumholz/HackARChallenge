using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myFirstScript : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = 0f;
    }

    [SerializeField] private float rotationSpeed = 10f; // The rotation speed, set from the editor

    private void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f); // Rotate the object around its Y axis
    }

    public void StartSpinning()
    {
        rotationSpeed = 10f;
    }

    public void Stoppinning()
    {
        rotationSpeed = 0f;
    }
}
