using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimController : MonoBehaviour
{
    Animator anim;
    public TMP_Text SlideTextObj;

    public string SlideText { set => SlideTextObj.text = value; }

    Action<Animator> OnNext = delegate { };

    void Start()
    {
        anim = GetComponent<Animator>();
        SlideText = "";
    }

    public void Next()
    {
        OnNext?.Invoke(anim);
    }

    public void _Frame0Event()
	{
        SlideText = "Нажмите \"Далее\" чтобы начать туториал";
        OnNext = a =>
        {
            a.SetTrigger("1");
            SlideText = "1.Установите на блоке АКС-73 выключатель СЕТЬ — ОТКЛ. в положение СЕТЬ.";
        };
    }

    public  void _Frame1Event()
	{
        OnNext = a =>
        {
            a.SetTrigger("2");
            SlideText = "2.Нажмите кнопку ПИТАНИЕ ВКЛ. на пульте ПОС-72, при этом подается напряжение " +
            "накала на блоки и включаются вентиляторы обдува шкафов. Через минуту автоматически " +
            "подается на блоки анодное напряжение и на пульте ПОС-72 загорается сигнальная лампа " +
            "АНОД. Еще через минуту загорается сигнальная лампа ВЫСОКОЕ НАПРЯЖЕНИЕ — РАЗРЕШЕНО.";
        };
    }
}
