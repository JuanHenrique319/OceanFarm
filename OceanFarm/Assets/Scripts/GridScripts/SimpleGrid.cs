using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class SimpleGrid : MonoBehaviour
{
    [SerializeField] private int height;
    Transform tile;
    //public GameObject hudteste;//teste// nn funfa
    //[SerializeField] private GameObject cloneOBJ;
    [SerializeField] private Transform grid;

    

  
    void Start()
    {
        
    }
    


    void Update()
    {
        tile = GameObject.FindGameObjectWithTag("Build").transform;
       /* if (Input.GetMouseButton(0) && hudteste.activeSelf)// condição de teste só funciona em ambiente onde existe apenas um unico obj a ser instanciado
        {
       nn funfa
            construirObjteste();
        }*/
    }
   /* void construirObjteste()
    {
   nn funfa
        Instantiate(cloneOBJ, tile.transform.position, tile.transform.rotation);
    }*/

    private void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit, 1000f))
        {
            Vector3 tilePos = new Vector3(Mathf.RoundToInt(hit.point.x), height, Mathf.RoundToInt(hit.point.z));

            if(hit.collider != null)
            {
                tile.position = tilePos;
            }
        }
    }

}
