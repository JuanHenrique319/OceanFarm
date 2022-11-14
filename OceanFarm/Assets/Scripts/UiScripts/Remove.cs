using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Remove : MonoBehaviour
{
    [SerializeField] private Sprite SpriteON;
    [SerializeField] private Sprite SpriteOFF;
    public bool IsDeleting = false;
    public Button edit;
    // Start is called before the first frame update

    public void OnDelete()
    {
        IsDeleting = !IsDeleting;
        if (IsDeleting)
        {
            GetComponent<Image>().sprite = SpriteOFF;
            edit.enabled = false;
        }
        else
        {
            GetComponent<Image>().sprite = SpriteON;
            edit.enabled = true;
        }
        
    }
}
