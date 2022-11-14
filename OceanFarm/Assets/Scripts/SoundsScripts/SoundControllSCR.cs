using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControllSCR : MonoBehaviour
{
    /// Descrição 
    /// impende que o som seja apagado ao mudar de cena ou que seja duplicado ao dar reload na cena
    /// ainda não adicionado mas pretendo colocar aqui tbm a possibilidade de rodar sons aleatorios por porcentagem de probabilidade
    /// Descrição 

    public static SoundControllSCR instance;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
