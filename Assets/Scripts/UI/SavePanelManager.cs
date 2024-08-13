using UnityEngine;
using TMPro;
using System;
using System.IO;
public class SavePanelManager : MonoBehaviour
{
  
    public GameObject panel;
    public TMP_InputField folder;
    public TMP_InputField file;
    public void updateFolder(string s) {
        DialogueTreeManager.tree.folder = s;
    }
    public void updateFile(string s) {
        DialogueTreeManager.tree.file = s;
    }
    public void loadPanel() {
        panel.SetActive(true);
        folder.text = DialogueTreeManager.tree.folder;
        if (folder.text == "") {

            DialogueTreeManager.tree.folder = Application.persistentDataPath;
            folder.text = DialogueTreeManager.tree.folder;

        }
        file.text = DialogueTreeManager.tree.file;
        if(file.text == "") {
            DialogueTreeManager.tree.file = "conversation";
            file.text = DialogueTreeManager.tree.file;
        }

    }
    public void resetpath()
    {
        DialogueTreeManager.tree.folder = Application.persistentDataPath;
        DialogueTreeManager.tree.file = "conversation";
        folder.text = DialogueTreeManager.tree.folder;
        file.text = DialogueTreeManager.tree.file;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
