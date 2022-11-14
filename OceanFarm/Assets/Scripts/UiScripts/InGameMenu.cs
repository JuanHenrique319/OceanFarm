using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenu : MonoBehaviour
{

    [SerializeField] private GameObject MenuinGame;
    private bool IsActive = false;
    // Start is called before the first frame update

    public void Onclick()
    {
        IsActive = !IsActive;
        if(IsActive)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
        MenuinGame.SetActive(IsActive);
    }
}
