using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEndTrigger : MonoBehaviour
{
    int result = DiceCheckZoneScript.result;
    int low = 1;
    int levelstoComplete;

    void Start()
    {
        Debug.Log(result);
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            levelstoComplete = result - low;
            Debug.Log(levelstoComplete);
        }
    }
}
