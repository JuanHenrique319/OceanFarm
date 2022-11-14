using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ResourceTest : MonoBehaviour
{
    [SerializeField] private float tempo = 5;

    //
    [SerializeField] private float gridSize;
    [SerializeField] GameObject pendingObj;
    [SerializeField] private LayerMask layerMask;
    private RaycastHit hit;
    private bool clickthis = false;
    private Vector3 pos;
    private void Awake()

    {
        StartCoroutine(Resource());
        pendingObj = this.gameObject;
    }
    IEnumerator Resource()
    {
        yield return new WaitForSeconds(tempo);
        FindObjectOfType<ResourceController>().addcomida();
        yield return new WaitForSeconds(tempo);
        StartCoroutine(Resource());

    }
    private void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 1000, layerMask))
        {
            pos = hit.point;
        }
    }

   
    private void OnMouseDown()
    {
        if (FindObjectOfType<Edit>().IsEditing)
        {
            clickthis = !clickthis;
        }
        if (FindObjectOfType<Remove>().IsDeleting)
        {
            Destroy(this.gameObject);
        }
        
    }
    void Update()
    {
        if (clickthis)
        {
           if(1==1) {
                pendingObj.transform.position = new Vector3(
                RoundToNearestGrid(pos.x),
                RoundToNearestGrid(pos.y + 0.51f),
                RoundToNearestGrid(pos.z));
                if (Input.GetMouseButtonDown(1))
                {
                    clickthis = !clickthis;
                }
            }
            else
            {
                pendingObj.transform.position = pos;
            }

        }
        
    }
    float RoundToNearestGrid(float pos)
    {
        float xDiff = pos % gridSize;

        pos -= xDiff;

        if (xDiff > (gridSize / 2))
        {
            pos += gridSize;
        }

        return pos;

    }
}
