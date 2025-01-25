using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class MenuHandler : MonoBehaviour{
    public TMP_InputField nameInputField;
    public Button startButton;

    public void OnStartButtonClick() {
        if (MainManager.Instance != null){
            MainManager.Instance.Name = nameInputField.text;
        }

        SceneManager.LoadScene("main");
    }

    void Start(){
        startButton.onClick.AddListener(OnStartButtonClick);
    }

    void Update(){
    }
}
