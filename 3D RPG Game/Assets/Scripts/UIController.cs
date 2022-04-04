using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class UIController : MonoBehaviour
{

    public Button startButton;
    public Button controlsButton;
    public Button exitButton;
    public Label messageText;
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        startButton = root.Q<Button>("start-button");
        controlsButton = root.Q<Button>("controls-button");
        exitButton = root.Q<Button>("exit-button");
        messageText = root.Q<Button>("message-text");

        startButton.clicked += StartButtonPressed;
        

    }

    void StartButtonPressed(){
        SceneManager.LoadScene("game");
    }
    void ControlsButtonPressed(){
        
    }
    void ExitButtonPressed(){
        
    }
   // void MessageButtonPressed(){
     //   messageText.text = "Hell Yeah";
       // messageText.style.display = DisplayStyle.Flex;
    //}
}
