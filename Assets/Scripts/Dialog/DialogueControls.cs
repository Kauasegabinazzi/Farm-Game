using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControls : MonoBehaviour
{

    [Header("Components")]
    public GameObject dialogueOb; // janela dialogo
    public Image profileSprite; // sprite perfil
    public Text speechText; // texto fala
    public Text actorNameText; // nome npc

    [Header("Settings")]
    public float typingSpeed; // velocidade da fala

    //variaveis de controle
    private bool isShowing; // janela vizivel
    private int index; // index sentencia
    private string[] sentence;

    public static DialogueControls instance;

    //awake é chamdo antes do start
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator TypeSentence()
    {
        foreach (char letter in sentence[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    //pular para proxima fala
    public void NextSentence()
    {

    }

    //chamar a fala do npc
    public void Speech(string[] txt)
    {
        if (!isShowing)
        {
            dialogueOb.SetActive(true);
            sentence = txt; 
            StartCoroutine(TypeSentence());
            isShowing = true;
        }
    }
}
