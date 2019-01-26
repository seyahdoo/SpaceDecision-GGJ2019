using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BedSequence : MonoBehaviour
{

    public Camera PlayerCamera;
    public GameObject PlayerController;
    public Transform TargetTransform;
    public float position_speed;
    public float rotation_speed;

    public bool test = false;

    // Update is called once per frame
    void Update()
    {
        if(test || Input.GetKeyDown(KeyCode.I))
        {
            test = false;
            StartBedSequence();
        }
    }

    public void StartBedSequence()
    {
        StartCoroutine(BedSequenceEnumerator());
    }

    IEnumerator BedSequenceEnumerator()
    {

        PlayerController.SetActive(false);

        var parent = PlayerCamera.transform.parent;
        PlayerCamera.transform.parent = null;

        float f = 0;
        Vector3 st = PlayerCamera.transform.position;
        Quaternion sq = PlayerCamera.transform.rotation;
        while (f < 1)
        {
            f += Time.deltaTime / 4f;
            PlayerCamera.transform.position = Vector3.Lerp(st, TargetTransform.position, f);
            PlayerCamera.transform.rotation = Quaternion.Lerp(sq, TargetTransform.rotation, f);
            yield return new WaitForEndOfFrame();
        }

        PlayerCamera.transform.position = TargetTransform.position;
        PlayerCamera.transform.rotation = TargetTransform.rotation;

    }


}
