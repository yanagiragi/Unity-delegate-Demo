using UnityEngine;
using System.Collections;

/*
 *  Author:     yanagiragi 
 *  Purpose:    Base Class of Trigger Function
 */

public class BaseTrigger : MonoBehaviour
{
    public delegate void exceutable();
    protected exceutable p_Instance = null; // should be initialized in child class

    public exceutable getTrigger()
    {
        if (p_Instance == null)
        {
            // throw Exception is Better?
            Debug.LogError("Attempt to call trigger function before initialized it.");
            return delegate { };
        }
        else
        {
            return p_Instance;
        }        
    }
}
