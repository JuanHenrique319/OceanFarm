using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conquists : MonoBehaviour
{
    [Header("conquistas")]
    public int meta = 5;
    [SerializeField] GameObject conquistasobj;
    [SerializeField] private Text TxtConquist;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TxtConquist.text = ("Parabéns você conseguiu bater uma meta de produção com " + (int)meta + " de aliemntos de cada tipo, a próxima meta é " + (meta + 10)).ToString();
        if (FindObjectOfType<ResourceController>().comida>= meta && FindObjectOfType<ResourceController>().comidaPec >= meta)
        {
            StartCoroutine(hudaparece());
            meta += 10;
        }
    }
    IEnumerator hudaparece()
    {
        conquistasobj.SetActive(true);
        yield return new WaitForSeconds(5f);
        conquistasobj.SetActive(false);
    }
}
