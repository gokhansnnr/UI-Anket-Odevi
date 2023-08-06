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

    public void exitButton() //Ana sayfaya çýkýlacak buton
    {
        print("Ana sayfaya çýkýþ saðlandý");
        SceneManager.LoadScene("HomePage");
    }

    public void Opt1ToggleEnabled(bool toggleClicked)
    {
        if (toggleClicked)
        {
            ansText1.text = "Sosyal medyadan öðrendim.";
        }
    }

    public void Opt2ToggleEnabled(bool toggleClicked)
    {
        if (toggleClicked)
        {
            ansText1.text = "Web sayfanýzdan öðrendim.";
        }
    }

    public void Opt3ToggleEnabled(bool toggleClicked)
    {
        if (toggleClicked)
        {
            ansText1.text = "Çeþitli oyun platformlarýndan öðrendim.";
        }
    }

    public void Opt4ToggleEnabled(bool toggleClicked)
    {
        if (toggleClicked)
        {
            ansText1.text = "Arkadaþlarým tavsiye etti.";
        }
    }

    public void RadioEnabled(bool radioClicked)
    {
        if (radioClicked)
        {
            ansText3.text = "Oyunu arkadaþlarýma önerdim.";
        }
        else
        {
            ansText3.text = "Oyunu arkadaþlarýma henüz önermedim.";
        }
        
    }

    public void on_Value_Changed(float value)
    {
        if (value >= 0.8)
        {
            ansText2.text = "Beðeni Puaným: " + value + ".\t" + "Oyununuzu çok beðendim";
        }else if (value >= 0.6)
        {
            ansText2.text = "Beðeni Puaným: " + value + ".\t" + "Oyununuz fena deðil";
        }
        else if (value >= 0.4)
        {
            ansText2.text = "Beðeni Puaným: " + value + ".\t" + "Oyununuz iyi sayýlmaz ama kötü de deðil";
        }
        else if (value >= 0.2)
        {
            ansText2.text = "Beðeni Puaným: " + value + ".\t" + "Oyununuzu pek beðendiðimi söyleyemeyeceðim.";
        }
        else
        {
            ansText2.text = "Beðeni Puaným: " + value + ".\t" + "Oyununuzu beðenmedim. Üzerinde biraz daha çalýþýn!";
        }
    }

    public void OnEndEditText(string textValue) //8- InputField için
    {
        ansText4.text = textValue;
    }

    public void ShowView() //Panel açma
    {
        panel.gameObject.SetActive(true);
    }

    public void CloseView()//Panel kapama
    {
        panel.gameObject.SetActive(false);
    }

    public void SendButton()//Gönderme
    {
        print("Gönderim Baþarýlý!");
        SceneManager.LoadScene("HomePage");
    }

}
