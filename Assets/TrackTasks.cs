using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrackTasks : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI myTextElement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myTextElement.text = "Tasks Done (0/4)";
    }
}
