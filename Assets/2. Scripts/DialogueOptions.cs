using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Dialogue Option", menuName = "Dialogue Options")]

public class DialogueOptions : DialogueBase
{
    [TextArea(2, 10)]
    public string questionText;

    [System.Serializable]
    public class Options
    {
        public string buttonName;
        public DialogueBase nextDialogue;
        public UnityEvent myEvent;


    }
    public Options[] optionsInfo;

    
    
}
