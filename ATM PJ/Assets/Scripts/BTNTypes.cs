using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTNTypes : MonoBehaviour
{
    public BTNType currentBtnType;
    public CanvasGroup MainBtnGroup;
    public CanvasGroup TabBtnGroup;
    public GameObject TabInputBtn;
    public GameObject TabOutputBtn;
    public void OnClick()
    {
        switch (currentBtnType)
        {
            case BTNType.Input:
                CanvasGroupOn(TabBtnGroup);
                CanvasGroupOff(MainBtnGroup);
                TabOutputBtn.SetActive(false);
                TabInputBtn.SetActive(true);
                break;

            case BTNType.Output:
                CanvasGroupOn(TabBtnGroup);
                CanvasGroupOff(MainBtnGroup);
                TabInputBtn.SetActive(false);
                TabOutputBtn.SetActive(true);
                break;

            case BTNType.Back:
                CanvasGroupOn(MainBtnGroup);
                CanvasGroupOff(TabBtnGroup);
                break;

            case BTNType.CheckBack:
                InOut.I.Panel.SetActive(false);
                break;

            case BTNType.One:
                InOut.I.inputTxt_Money.text = (10000).ToString();
                break;

            case BTNType.Three:
                InOut.I.inputTxt_Money.text = (30000).ToString();
                break;

            case BTNType.Five:
                InOut.I.inputTxt_Money.text = (50000).ToString();
                break;

        }
    }

    public void CanvasGroupOn(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
    public void CanvasGroupOff(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }
}
