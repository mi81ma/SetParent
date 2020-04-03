using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(CountDown()); // Set CountDown function by StartCoroutine()
    }

    // Make some function
    IEnumerator CountDown()
    {
       Debug.Log("CountDown Start"); // Log out
       while (true)
       {
            yield return new WaitForSeconds(1); // Wait 1 second
            Debug.Log("After 1 second"); // Log out
       }
    }
}
