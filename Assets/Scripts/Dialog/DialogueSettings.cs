using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Dialogue", menuName = "New Dialogue/Dialogue")]

public class DialogueSettings : ScriptableObject
{
    [Header("Settings")]
    public GameObject actor;

    [Header("Dialogue")]
    public Sprite speaker;
    public string sentence;

    public List<sentences> dialogues = new List<sentences>();

    [System.Serializable]
    public class sentences
    {
        public string actorName;
        public Sprite profile;
        public languages sentence;
    }

    [System.Serializable]
    public class languages
    {
        public string portuguese;
        public string english;
        public string spanish;

    }
}
