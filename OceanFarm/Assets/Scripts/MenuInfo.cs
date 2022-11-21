using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MenuInfo : MonoBehaviour
{
    public BuildSO build;
    public TextMeshProUGUI txtName;
    public TextMeshProUGUI txtPrice;
    public Image imgSprite;


    void OnEnable()
    {
        txtName.text = build.buildName;
        //txtPrice.text = build.price.ToString();
        imgSprite.sprite = build.sprite;


    }

   
}
