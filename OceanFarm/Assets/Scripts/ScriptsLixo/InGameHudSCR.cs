using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameHudSCR : MonoBehaviour
{

    /// Descrição 
    /// Sistema básico de hud
    /// Descrição 
    public GameObject Hud;
    public GameObject obj;
    public GameObject obj2;
    public GameObject Ui;
    public bool isClicking=false;
    public bool isPressed=false;

    public void Click()
    {
        //ao clicar ativa o subhud
        isClicking = !isClicking;
        Hud.SetActive(isClicking);

    }
    public void ClickInstOBJ()
    {
       
        Ui.GetComponent<SimpleGrid>().enabled = true;

        Instantiate(obj, obj.transform.position, obj.transform.rotation);
        isPressed = true;
        
        //instancia o obj que serve para saber onde vai ser colocado e desativa o subhud
    }
    private void Update()
    {
        if (isPressed)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(obj2, GameObject.FindGameObjectWithTag("Build").transform.position, GameObject.FindGameObjectWithTag("Build").transform.rotation);
            }

        }
    }
    private void FixedUpdate()
    {
        print(isClicking);
       
    }

}
