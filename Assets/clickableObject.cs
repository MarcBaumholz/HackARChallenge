using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  MagicLeap.Examples;

public class clickableObject : MonoBehaviour
{
    private GameObject alternativeGO = null;
    private bool _visibility=false;

    private void ShowDetails(bool active)
        {
            if (_details != null)
            {
                _details.SetActive(active);
            }
        }
    public override void Hover()
        {
            base.Hover();

            onClickOpen(_isHover);
        }
    private void ClickOpen(bool _visibility)
    {    
            if (alternativeGO != null)
            {
                alternativeGO.SetActive(_visibility);
            }
    }
    public void clickClose()
    {
            _visibility = false;
            alternativeGO.SetActive(_visibility);
    }

    public void onClickOpen()
    {    
            _visibility = true;
            alternativeGO.SetActive(_visibility);
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
        _visibility = false;
        alternativeGO.SetActive(_visibility);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
