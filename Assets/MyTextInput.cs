using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class MyTextInput : NetworkBehaviour
{

    InputField input;
    InputField.SubmitEvent se;
    public Text output;

    void Start()
    {
        input = gameObject.GetComponent<InputField>();
        se = new InputField.SubmitEvent();
        se.AddListener(SubmitInput);
        input.onEndEdit = se;

    }

    void Update()
    {
        //chat(input.text);

    }
    

    private void SubmitInput(string arg0)
    {
        string currentText = output.text; //maybe add ToString()?
        string newText = currentText + "\n" + arg0;
        output.text = newText;
        input.text = "";
        input.ActivateInputField();
    }
    /*
    public void chat(string message)
    {
        CmdChat(message);
    }

    [Command]
    void CmdChat(string message)
    {
        RpcChat(message);
    }

    [ClientRpc]
    void RpcChat(string message)
    {
        output.text += message;
        output.text += "\n";
    }*/

}
