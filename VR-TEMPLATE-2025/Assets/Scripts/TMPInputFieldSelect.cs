using UnityEngine;
using TMPro;
using UnityEngine.EventSystems; 

public class TMPInputFieldSelect : MonoBehaviour
{
   
    public int thisInput;
    public GameObject keyboard;
    public GameObject panel;


    private bool IsMobile() { return Application.isMobilePlatform; }
    public void SelectKeyboard(int keyBoardType)
    {
        //  Debug.Log("TMP_InputField foi selecionado!");


       
    }
}

