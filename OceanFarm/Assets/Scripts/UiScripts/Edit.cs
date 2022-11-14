using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Edit : MonoBehaviour
{
    [SerializeField] private Sprite SpriteON;
    [SerializeField] private Sprite SpriteOFF;
    public bool IsEditing = false;
    public Button remove;

// Start is called before the first frame update

public void OnEdit()
{
    IsEditing = !IsEditing;
        if (IsEditing)
        {
            GetComponent<Image>().sprite = SpriteOFF;
            remove.enabled = false;

        }
        else
        {
            GetComponent<Image>().sprite = SpriteON;
            remove.enabled = true;


        }
}
    }
    