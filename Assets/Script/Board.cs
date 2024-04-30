using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [Header("Players")]
    public GameObject PlayerOne;
    public GameObject InputPlayerOne;
    public GameObject PlayerTwo;
    public GameObject InputPlayerTwo;

    [Header("World")]
    public GameObject Slot1;
    public GameObject Input1;
    public GameObject Slot2;
    public GameObject Input2;

    [Header("Destiny")]
    public GameObject[] Slots = new GameObject[6];
    public GameObject[] Inputs = new GameObject[6];

    // Fonction appelée avant la première mise à jour de frame
    void Start()
    {
        InitialiserTextMeshPourInputs();
    }

    // Initialise les TextMesh pour chaque GameObject dans le tableau Inputs pour afficher le nom du Slot correspondant
    private void InitialiserTextMeshPourInputs()
    {
        for (int i = 0; i < Inputs.Length; i++)
        {
            if (Inputs[i] != null && Slots[i] != null)
            {
                CreerTextMesh(Inputs[i], Slots[i].name); // Utilisation du nom du Slot correspondant comme texte
            }
        }
    }

    // Crée un TextMesh pour un GameObject spécifique et le configure avec un texte spécifié
    private void CreerTextMesh(GameObject input, string texte)
    {
        GameObject textObj = new GameObject("TextOnInput");
        textObj.transform.parent = input.transform;
        textObj.transform.localPosition = new Vector3(0, 0, 0.5f); // Positionnez le texte à l'avant de l'Input
        textObj.transform.localRotation = Quaternion.LookRotation(Vector3.forward);

        TextMesh textMesh = textObj.AddComponent<TextMesh>();
        textMesh.text = texte; // Utilisation du texte passé en paramètre
        textMesh.characterSize = 0.1f;
        textMesh.anchor = TextAnchor.MiddleCenter;
        textMesh.alignment = TextAlignment.Center;
        textMesh.fontSize = 100;
        textMesh.color = Color.black;

        // Ajustez la taille et la position du texte si nécessaire
        textObj.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }

    // Fonction appelée à chaque frame
    void Update()
    {
        
    }
}