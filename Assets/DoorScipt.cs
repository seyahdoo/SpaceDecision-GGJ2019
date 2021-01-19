using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorScipt : MonoBehaviour
{

    public Transform openState;
    public Transform closeState;
    public Transform playerPos;
    public Transform doorPos;
    public float openDistance;

    public bool opened;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Vector3.Distance(playerPos.position, doorPos.position) < openDistance)
        {
            if (!opened)
            {
                opened = true;
                StartCoroutine(OpenDoor());
            }
        }
        else
        {
            if (opened)
            {
                opened = false;
                StartCoroutine(CloseDoor());
            }
        }

    }

    IEnumerator OpenDoor()
    {
        float f = 0;
        Vector3 st = transform.position;
        while (f < 1)
        {
            f += Time.deltaTime / .20f;
            transform.position = Vector3.Lerp(st, openState.position, f);
            yield return new WaitForEndOfFrame();
        }

        transform.position = openState.position;

    }

    IEnumerator CloseDoor()
    {
        float f = 0;
        Vector3 st = transform.position;
        while (f < 1)
        {
            f += Time.deltaTime / .20f;
            transform.position = Vector3.Lerp(st, closeState.position, f);
            yield return new WaitForEndOfFrame();
        }

        transform.position = closeState.position;
    }
    
}
