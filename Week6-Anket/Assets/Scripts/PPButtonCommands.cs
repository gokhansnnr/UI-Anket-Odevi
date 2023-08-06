using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PPButtonCommands : MonoBehaviour
{

    public GameObject panel;
    public TMP_Text ansText1, ansText2, ansText3, ansText4;

    public void exitButton() //Ana sayfaya ��k�lacak buton
    {
        print("Ana sayfaya ��k�� sa�land�");
        SceneManager.LoadScene("HomePage");
    }

    public void Opt1ToggleEnabled(bool toggleClicked)
    {
        if (toggleClicked)
        {
            ansText1.text = "Sosyal medyadan ��rendim.";
        }
    }

    public void Opt2ToggleEnabled(bool toggleClicked)
    {
        if (toggleClicked)
        {
            ansText1.text = "Web sayfan�zdan ��rendim.";
        }
    }

    public void Opt3ToggleEnabled(bool toggleClicked)
    {
        if (toggleClicked)
        {
            ansText1.text = "�e�itli oyun platformlar�ndan ��rendim.";
        }
    }

    public void Opt4ToggleEnabled(bool toggleClicked)
    {
        if (toggleClicked)
        {
            ansText1.text = "Arkada�lar�m tavsiye etti.";
        }
    }

    public void RadioEnabled(bool radioClicked)
    {
        if (radioClicked)
        {
            ansText3.text = "Oyunu arkada�lar�ma �nerdim.";
        }
        else
        {
            ansText3.text = "Oyunu arkada�lar�ma hen�z �nermedim.";
        }
        
    }

    public void on_Value_Changed(float value)
    {
        if (value >= 0.8)
        {
            ansText2.text = "Be�eni Puan�m: " + value + ".\t" + "Oyununuzu �ok be�endim";
        }else if (value >= 0.6)
        {
            ansText2.text = "Be�eni Puan�m: " + value + ".\t" + "Oyununuz fena de�il";
        }
        else if (value >= 0.4)
        {
            ansText2.text = "Be�eni Puan�m: " + value + ".\t" + "Oyununuz iyi say�lmaz ama k�t� de de�il";
        }
        else if (value >= 0.2)
        {
            ansText2.text = "Be�eni Puan�m: " + value + ".\t" + "Oyununuzu pek be�endi�imi s�yleyemeyece�im.";
        }
        else
        {
            ansText2.text = "Be�eni Puan�m: " + value + ".\t" + "Oyununuzu be�enmedim. �zerinde biraz daha �al���n!";
        }
    }

    public void OnEndEditText(string textValue) //8- InputField i�in
    {
        ansText4.text = textValue;
    }

    public void ShowView() //Panel a�ma
    {
        panel.gameObject.SetActive(true);
    }

    public void CloseView()//Panel kapama
    {
        panel.gameObject.SetActive(false);
    }

    public void SendButton()//G�nderme
    {
        print("G�nderim Ba�ar�l�!");
        SceneManager.LoadScene("HomePage");
    }

}
