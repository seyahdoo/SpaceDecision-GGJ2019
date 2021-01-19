using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using seyahdoo.crosshair;

public class BedController : Target
{

    public float triggerDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void FocusOn()
    {

        base.FocusOn();
    }

    public override void FocusStay()
    {
        base.FocusStay();

        

    }

    public override void FocusOff()
    {
        base.FocusOff();
    }
}
