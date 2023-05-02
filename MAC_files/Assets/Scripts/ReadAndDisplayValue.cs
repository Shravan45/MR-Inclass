using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class ReadAndDisplayValue : MonoBehaviour
{

    public InputActionReference inputReference = null;
    public TextMeshProUGUI valueText;

    void Start()
    {
        
    }

    void Update()
    {
        valueText.text = inputReference.action.ReadValue<Vector2>().ToString();
    }
}
