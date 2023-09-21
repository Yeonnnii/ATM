using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InOut : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI txt_Cash;
    [SerializeField] private TextMeshProUGUI txt_Money;
    [SerializeField] public TMP_InputField inputTxt_Money;

    public static InOut I;
    public GameObject Panel;

    //public Animator anim;

    private int currentMoney=50000;
    private int currentCash=100000;

    private int previousMoney;
    private int previousCash;
    public void Input()
    {
        int CashToAdd = int.Parse(inputTxt_Money.text);
        if (currentCash - CashToAdd >= 0)
        {
            currentMoney += CashToAdd;
            currentCash -= CashToAdd;
            //anim.SetBool("isIn", true);
        }
        else
        {
            currentMoney = previousMoney;
            currentCash = previousCash;
            Panel.SetActive(true);
        }
        txt_Money.text = currentMoney.ToString("N0");
        txt_Cash.text = currentCash.ToString("N0");
    }
    public void Output()
    {
        int moneyToAdd = int.Parse(inputTxt_Money.text);
        if (currentMoney - moneyToAdd >= 0)
        {
            currentMoney -= moneyToAdd;
            currentCash += moneyToAdd;
            //anim.SetBool("isOut", true);
        }
        else
        {
            currentMoney = previousMoney;
            currentCash = previousCash;
            Panel.SetActive(true);
        }
        txt_Money.text = currentMoney.ToString("N0");
        txt_Cash.text = currentCash.ToString("N0");
    }

    void Awake()
    {
        I = this;
    }

    private void Start()
    {

    }

    private void Update()
    {
        previousMoney = currentMoney;
        previousCash = currentCash;
        txt_Money.text = currentMoney.ToString("N0");
        txt_Cash.text = currentCash.ToString("N0");
    }

}
