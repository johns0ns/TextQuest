using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step : MonoBehaviour
{

    [TextArea(minLines: 10, maxLines: 15)] public string content = "Перед вами 2 Двери:   \n 1.Первая дверь \n 2.Вторая дверь";

    //public Step nextStep1;
    //public Step nextStep2;
    public Step[] nextSteps;
    public Sprite Image;
   
}
