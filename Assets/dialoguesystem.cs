using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using TMPro;
using UnityEngine.UI;

public class dialoguesystem : MonoBehaviour
{
    public TextAsset inkJsonAsset;
    public TextMeshProUGUI dialogueText;
    public Button[] choiceButtons;

    private Story story;

    void Start()
    {
        story = new Story(inkJsonAsset.text);
        ContinueDialogue();
    }

    public void ContinueDialogue()
    {
        if (story.canContinue)
        {
            string text = story.Continue();
            dialogueText.text = text;
        }
        else if (story.currentChoices.Count > 0)
        {
            for (int i = 0; i < choiceButtons.Length; i++)
            {
                if (i < story.currentChoices.Count)
                {
                    choiceButtons[i].gameObject.SetActive(true);
                    choiceButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = story.currentChoices[i].text;
                }
                else
                {
                    choiceButtons[i].gameObject.SetActive(false);
                }
            }
        }
        else
        {
            EndDialogue();
        }
    }

    public void ChooseOption(int index)
    {
        story.ChooseChoiceIndex(index);
        ContinueDialogue();
    }

    private void EndDialogue()
    {
        // Handle end of dialogue
    }
}
