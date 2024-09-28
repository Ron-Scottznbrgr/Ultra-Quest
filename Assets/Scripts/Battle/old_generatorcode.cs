/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// generic parent class to all other character classes

public class battle_GenericCharacterClass : MonoBehaviour
{

    public byte fAff, wAff, eAff, aAff;
    public short atk, def, spd, hp;
    public string characterName;

    GameObject Char1Field;
    Text generatedValues;



    private void Start()
    {
        generateValues();
        Char1Field = GameObject.Find("Char1");
        generatedValues = Char1Field.GetComponent<Text>();
        generatedValues.text = characterName + "\n-----------------\n" +
            "Atk: " + atk + "\t\tF:AFF: " + fAff + "\n" +
             "Def: " + def + "\t\tE:AFF: " + eAff + "\n" +
              "Spd: " + spd + "\t\tW:AFF: " + wAff + "\n" +
               "Hp: " + hp + "\t\tA:AFF: " + aAff;

    }

    public void generateValues()
    {
        characterName = "Ryuko";
        fAff = (byte)Random.Range(0f, 100f);
        wAff = (byte)Random.Range(0f, 100f);
        aAff = (byte)Random.Range(0f, 100f);
        eAff = (byte)Random.Range(0f, 100f);
        atk = (short)Random.Range(5f, 400f);
        def = (short)Random.Range(5f, 400f);
        spd = (short)Random.Range(5f, 400f);
        hp = (short)Random.Range(20f, 5000f);
    }

    public void retext()
    {
        Char1Field = GameObject.Find("Char1");
        generatedValues = Char1Field.GetComponent<Text>();
        generatedValues.text = characterName + "\n-----------------\n" +
            "Atk: " + atk + "\t\tF:AFF: " + fAff + "\n" +
             "Def: " + def + "\t\tE:AFF: " + eAff + "\n" +
              "Spd: " + spd + "\t\tW:AFF: " + wAff + "\n" +
               "Hp: " + hp + "\t\tA:AFF: " + aAff;
    }
}
*/