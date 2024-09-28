using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class battle_RegenStats : MonoBehaviour {

    //public Button RegenButton;
    private battle_GenerateCharacters Generator;

    // Use this for initialization
    void Start() {
       // Button regenbtn = RegenButton.GetComponent<Button>();

        //regenbtn.onClick.AddListener(regenClicked);

        Generator = FindObjectOfType<battle_GenerateCharacters>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            regenClicked();
        }
    }

    void regenClicked(){
        Generator.GenerateCharacters();
        

        }

}
