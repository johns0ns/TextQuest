using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuestGame : MonoBehaviour
{
    [Header("Elements")]
    public Text titleText;
    public Text gametext;

    [Header("Config")]
    [Tooltip("Название игры")] public string title = "Game Title";

    [TextArea(minLines:10,maxLines:15)] public string content = "Перед вами 2 выхода:   \n 1.Выход один \n 2.Выход два \n 3.Выйти";
    // Start is called before the first frame update
    void Start()
    {
        titleText.text = title;
        gametext.text = content;
       

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
