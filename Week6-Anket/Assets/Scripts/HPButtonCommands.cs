using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HPButtonCommands : MonoBehaviour
{

    public void exitButton() //Çýkýþ yapýlmasýný saðlayacak komut.
    {
        print("Oyundan Çýkýþ Saðlandý");
        Application.Quit();
    }

    public void JoinPollButton() //Anket sayfasýna gidiþ
    {
        SceneManager.LoadScene("PollPage");
    }

    public void MayBeLaterButton() //Kýrmýzý buton
    {
        print("Daha sonra yapýlacakmýþ :)");
    }

}
