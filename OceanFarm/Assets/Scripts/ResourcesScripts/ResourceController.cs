using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class ResourceController : MonoBehaviour
{
    [Header("Agro")]
    public int comida = 0;
    [SerializeField] private Text ComidaTxt;
    [Header("Pec")]
    public int comidaPec = 0;
    [SerializeField] private Text PecTxt;
    [Header("Madeira")]
    public int Wood = 0;
    [SerializeField] private Text WoodTxt;
    [Header("Rocha")]
    public int Rock = 0;
    [SerializeField] private Text RockTxt;
    [Header("Mana")]
    public int Mana = 0;
    [SerializeField] private Text ManaTxt;

    private bool onetime = true;
    private int meta = 200;
    private void Update()
    {
        ComidaTxt.text =((int)comida).ToString();
        PecTxt.text =((int)comidaPec).ToString();
        WoodTxt.text = ((int)Wood).ToString();
        RockTxt.text = ((int)Rock).ToString();
        ManaTxt.text = ((int)Mana).ToString();
        if (FindObjectOfType<Calendar>().month == 12 && onetime)
        {
            meta += meta;
            print("Recursos Coletados");
            FindObjectOfType<ResourceController>().Colect();
            onetime = false;
        }
        if (FindObjectOfType<Calendar>().month == 1)
        {
            onetime = true;
        }
    }

    //Ganhar Recursos
    public void addcomida()
    {
        comida+= 5;
    }
    public void addPec()
    {
        comidaPec += 5;
    }
    public void addWood()
    {
        Wood += 5;
    }
    public void addRock()
    {
        Rock += 5;
    }
    public void addMana()
    {
        Mana += 5;
    }

    //Perder Recursos
    public void losecomida()
    {
        comida -= 5;
    }
    public void losePec()
    {
        comidaPec -= 5;
    }
    public void LoseWood()
    {
        Wood -= 5;
    }
    public void LoseRock()
    {
        Rock -= 5;
    }
    public void LoseMana()
    {
        Mana -= 5;
    }

    //Coleta de Recursos
    public void Colect()
    {
        comida -= meta;
        comidaPec -= meta;
    }
}
