using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] TMP_InputField textBox;
    [SerializeField] TMP_InputField printBox;

    private void Start()
    {
        Instance = this;
        printBox.text = "";
        textBox.text = "";
    }
    public void SetTextBox(TMP_InputField inputField)
    {
        textBox = inputField;
    }
    public void DeleteLetter()
    {
        if(textBox.text.Length != 0) {
            textBox.text = textBox.text.Remove(textBox.text.Length - 1, 1);
        }
    }

    public void AddLetter(string letter)
    {
        Debug.Log(textBox.gameObject.name);
        Debug.Log(textBox.text);
        textBox.text = textBox.text + letter;
    }

    public void SubmitWord()
    {
        printBox.text = textBox.text;
        textBox.text = "";
        // Debug.Log("Text submitted successfully!");
    }
}
