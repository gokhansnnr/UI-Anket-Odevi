using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HPButtonCommands : MonoBehaviour
{

    public void exitButton() //��k�� yap�lmas�n� sa�layacak komut.
    {
        print("Oyundan ��k�� Sa�land�");
        Application.Quit();
    }

    public void JoinPollButton() //Anket sayfas�na gidi�
    {
        SceneManager.LoadScene("PollPage");
    }

    public void MayBeLaterButton() //K�rm�z� buton
    {
        print("Daha sonra yap�lacakm�� :)");
    }

}
