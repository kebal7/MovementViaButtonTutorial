using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Set reference to Rigidbody
    public Rigidbody rb;

    //Public float for forward force editable from Unity Editor
    public float forwardforce = 100f;
    //Public float for sideways force editable from Unity Editor
    public float sidewaysforce = 100;

    //Bool for Forward
    public bool fw;
    //Bool for Backward
    public bool bw;
    //Bool for Right
    public bool rg;
    //Bool for Left
    public bool lf;


    // Start is called before the first frame update
    void Start()
    {
        //Make All Bool value false at start
        fw = false;
        bw = false;
        rg = false;
        lf = false;
    }


    void FixedUpdate()
    {
        //Call Forward function in FixedUpdate
        Forward();
        //Call Backward function in FixedUpdate
        Backward();
        //Call Right function in FixedUpdate
        Right();
        //Call Left function in FixedUpdate
        Left();
    }

    //Function to be called while forward button is holded
    public void DownForward()
    {
        // Makes fw value true while holding forward button
        fw = true;
    }

    //Function to be called when forward button is released
    public void UpForwad()
    {
        //Makes fw value false when forward button is released
        fw = false;
    }

    //Function to be called while backward button is holded
    public void DownBackwad()
    {
        //Makes bw value true while holding backward button
        bw = true;
    }

    //Function to be called when backward button is released
    public void UpBackward()
    {
        //Makes bw value false when backward button is released
        bw = false;
    }

    //Function to be called while Right button is holded
    public void DownRight()
    {
        //Makes rg value true while holding right button
        rg = true;
    }

    //Function to be called when right button is released
    public void UpRight()
    {
        //Makes rg value false when right button is released
        rg = false;
    }

    //Function to be called while Left button is holded
    public void DownLeft()
    {
        //Makes lf value true while holding left button
        lf = true;
    }

    //Function to be called when Left button is released
    public void UpLeft()
    {
        //Makes lf false when left button is released
        lf = false;
    }

    //Function to go forward
    public void Forward()
    {
        //Check is fw is true
        if(fw)
        {
            //AddForce is fw value is true
            rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        }
    }

    //Function to go backward
    public void Backward()
    {
        //Check if bw value is true
        if(bw)
        {
            //AddForce is bw value is true
            rb.AddForce(0, 0, -forwardforce * Time.deltaTime);
        }
    }


    //Function to go Right
    public void Right()
    {
        //Check if rg value is true
        if(rg)
        {
            //AddForce is rg value is true
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0);
        }
    }

    //Function to fo Left
    public void Left()
    {
        //Check is lf value is true
        if(lf)
        {
            //AddForce if lf value is true
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0);
        }
    }


}
