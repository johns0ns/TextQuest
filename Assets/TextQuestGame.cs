using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuestGame : MonoBehaviour
{
    [Header("Elements")]
    public Text titleText;
    public Text gametext;
    public Image gameImage;

    [Header("Config")]
    [Tooltip("Название игры")] public string title = "Начнем пожалуй!";
    public Step activeStep;
    
    void Start()
    {
        titleText.text = title;
        gametext.text = activeStep.content;


        //string[] dayOfTheWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        //Debug.Log(dayOfTheWeek[5]);
        //Debug.Log(dayOfTheWeek.Length);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CheckPress(0);
            gameImage.sprite = activeStep.Image;

           
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CheckPress(1);
            gameImage.sprite = activeStep.Image;
        }
        
    }

    void CheckPress(int index)
    {
        if (activeStep.nextSteps.Length > index)
        {
            activeStep = activeStep.nextSteps[index];
            gametext.text = activeStep.content;
        }


    }
}
