using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickOpen : MonoBehaviour
{
    [SerializeField] private GameObject SubhudMenu;
    public Button otherhud1, otherhud2, otherhud3, otherhud4, exclui, move;
    [SerializeField] private Sprite SpriteON;
    [SerializeField] private Sprite SpriteOFF;
    private bool IsActive =false;
    SpriteRenderer spriteimage;
    // Start is called before the first frame update
    public void FixedUpdate()
    {
        
    }
    public void Onclick()
    {
        IsActive = !IsActive;
        SubhudMenu.SetActive(IsActive);
        if (IsActive)
        {
            GetComponent<Image>().sprite = SpriteOFF;
        }
        else
        {
            GetComponent<Image>().sprite = SpriteON;
        }
        if (IsActive)
        {
            otherhud1.enabled = false;
            otherhud2.enabled = false;
            otherhud3.enabled = false;
            otherhud4.enabled = false;
            move.enabled = false;
            exclui.enabled = false;
        }
        else
        {
            otherhud1.enabled = true;
            otherhud2.enabled = true;
            otherhud3.enabled = true;
            otherhud4.enabled = true;
            move.enabled = true;
            exclui.enabled = true;
        }
    }
}
