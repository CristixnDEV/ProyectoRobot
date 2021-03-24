using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour
{
    [SerializeField] private List<Animator> animators;
    private bool _isCamChange = false;
    private bool _isInvert = false;

    public bool IsInvert => _isInvert;

    public bool IsCamChange => _isCamChange;
    
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Button": // Level 1
                animators[0].Play("RotatePlataform");
                break;
            case "Button2": // Level 2
                animators[0].Play("PlataformLevel2Run");
                break;
            case "CamChange": //cambiar camara de sitio
                _isCamChange = true;
                _isInvert = true;
                break;
            case "Button3": // level 3
                animators[0].Play("Plataform1Run");
                break;
            case "CamChange2":
                _isCamChange = true;
                break;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.tag)
        {
            case "CamChange":
                _isCamChange = false;
                _isInvert = false;
                break;
        }
    }

    private void OnCollisionStay(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Plataform2":
                animators[1].Play("AscensorRun"); // level 2
                break;
        }
    }
}
