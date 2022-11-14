using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseResourceTest : MonoBehaviour
{
    public Button thisBt;
    [SerializeField] private int Value;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<ResourceController>().Wood < Value)
        {
            thisBt.interactable = false;
        }
        else if (FindObjectOfType<ResourceController>().Wood >= Value)
        {
            thisBt.interactable = true;
        }
    }
    public void onclick()
    {
        FindObjectOfType<ResourceController>().LoseWood();
    }
}
