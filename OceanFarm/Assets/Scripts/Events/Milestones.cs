using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Milestones : MonoBehaviour
{
    [SerializeField] private int montcountdown = 12;
    [SerializeField] private Text MilistoneTxt;
    private int meta = 200;
    private bool onetime = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MilistoneTxt.text = ((12- FindObjectOfType<Calendar>().month) +" mês(ses) até a próxima entrega, Total Entrega ="+meta+"de comida dos dois tipos").ToString();
        if (FindObjectOfType<Calendar>().month == montcountdown&& onetime)
        {
            meta += meta;
            print("Recursos Coletados");
            FindObjectOfType<ResourceController>().Colect();
            onetime = false;
        }
        if(FindObjectOfType<Calendar>().month == 1)
        {
            onetime = true;
        }
    }
}
