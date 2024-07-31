/* Exit Detector by Ben Elwood
* Made for use by design students in the "Escape Lockdown 2030" project
* V2 published on 14/10/2020
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExitDetector : MonoBehaviour
{

    public UnityEvent OnExitSuccess = null;

    public bool[] corrects;

    public void addCorrect(int index)
    {
        bool everythingCorrect = true;
        corrects[index] = true;
        for (int i = 0; i < corrects.Length; i++)
        {
            if (corrects[i] == false)
            {
                everythingCorrect = false;
            }
        }
        if (everythingCorrect)
        {
            OnExitSuccess.Invoke();
        }
    }


}