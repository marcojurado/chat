using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class PlayerScript : MonoBehaviour
{
    private Text chatText;
    private InputField chatInput;
    private Button button;

    void start()
    {
        chatText = GameObject.Find("Text").GetComponent<Text>();
        chatInput = GameObject.Find("InputField").GetComponent<InputField>();
        button = GameObject.Find("Button").GetComponent<Button>();
    }

    void Update()
    {
        if (chatInput == null || chatText == null || button == null)
        {
            Debug.Log("chatInput or chatText or button are null");
            chatInput = GameObject.Find("InputField").GetComponent<InputField>();
            chatText = GameObject.Find("Text").GetComponent<Text>();
            button = GameObject.Find("Button").GetComponent<Button>();


        }
        else
        {
            Debug.Log("chatInput is set");
            Debug.Log(">>" + chatInput.text + "<<");
            InputField.OnChangeEvent change = chatInput.onValueChanged;
            //button.onClick;
            chatText.text = chatInput.text;
        }
    }
}