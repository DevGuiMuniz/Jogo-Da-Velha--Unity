using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameControl : MonoBehaviour
{
    public Text Text1;
    public Text Text2;
    public Text Text3;
    public Text Text4;
    public Text Text5;
    public Text Text6;
    public Text Text7;
    public Text Text8;
    public Text Text9;

    public bool turnX = true;
    public Text messageText;

    public void ClickButton1()
    {
        if (turnX == true)
        {

            Text1.text = "x";
            turnX = false;
            messageText.text ="Jogador: O";
        }
        else
        {
            Text1.text = "O";
            turnX = true;
             messageText.text ="Jogador: X";
        }
        VictoryCheck();

    }

    public void ClickButton2()
    {
        if (turnX == true)
        {

            Text2.text = "x";
            turnX = false;
            messageText.text ="Jogador: O";
        }
        else
        {
            Text2.text = "O";
            turnX = true;
            messageText.text ="Jogador: X";
        }

        VictoryCheck();
    }

    public void ClickButton3()
    {
        if (turnX == true)
        {

            Text3.text = "x";
            turnX = false;
              messageText.text ="Jogador: O";
        }
        else
        {
            Text3.text = "O";
            turnX = true;
              messageText.text ="Jogador: X";
        }
        VictoryCheck();

    }
    public void ClickButton4()
    {
        if (turnX == true)
        {

            Text4.text = "x";
            turnX = false;
              messageText.text ="Jogador: O";
        }
        else
        {
            Text4.text = "O";
            turnX = true;
              messageText.text ="Jogador: X";
        }
        VictoryCheck();

    }
    public void ClickButton5()
    {
        if (turnX == true)
        {

            Text5.text = "x";
            turnX = false;
              messageText.text ="Jogador: O";
        }
        else
        {
            Text5.text = "O";
            turnX = true;
              messageText.text ="Jogador: X";
        }
        VictoryCheck();

    }

    public void ClickButton6()
    {
        if (turnX == true)
        {

            Text6.text = "x";
            turnX = false;
              messageText.text ="Jogador: O";
        }
        else
        {
            Text6.text = "O";
            turnX = true;
              messageText.text ="Jogador: X";
        }
        VictoryCheck();

    }
    public void ClickButton7()
    {
        if (turnX == true)
        {

            Text7.text = "x";
            turnX = false;
              messageText.text ="Jogador: O";
        }
        else
        {
            Text7.text = "O";
            turnX = true;
              messageText.text ="Jogador: X";
        }
        VictoryCheck();

    }
    public void ClickButton8()
    {
        if (turnX == true)
        {

            Text8.text = "x";
            turnX = false;
              messageText.text ="Jogador: O";
        }
        else
        {
            Text8.text = "O";
            turnX = true;
              messageText.text ="Jogador: X";
        }
        VictoryCheck();

    }

    public void ClickButton9()
    {
        if (turnX == true)
        {

            Text9.text = "x";
            turnX = false;
              messageText.text ="Jogador: O";
        }
        else
        {
            Text9.text = "O";
            turnX = true;
              messageText.text ="Jogador: X";
        }
        VictoryCheck();

    }

    public void VictoryCheck()
    {
         //Horizontal
        if (Text1.text == "x" && Text2.text == "x" && Text3.text == "x")
        {

            messageText.text = "jogador X Ganhou";

        }

          if (Text1.text == "O" && Text2.text == "O" && Text3.text == "O")
        {

            messageText.text = "jogador O Ganhou";

        }

          if (Text4.text == "x" && Text5.text == "x" && Text6.text == "x")
        {

            messageText.text = "jogador X Ganhou";

        }

          if (Text4.text == "O" && Text5.text == "O" && Text6.text == "O")
        {

            messageText.text = "jogador O Ganhou";

        }
        if (Text7.text == "x" && Text8.text == "x" && Text9.text == "x")
        {

            messageText.text = "jogador X Ganhou";

        }

          if (Text7.text == "O" && Text8.text == "O" && Text9.text == "O")
        {

            messageText.text = "jogador O Ganhou";

        }
        //Vertical

         if (Text1.text == "x" && Text4.text == "x" && Text7.text == "x")
        {

            messageText.text = "jogador X Ganhou";

        }

          if (Text1.text == "O" && Text4.text == "O" && Text7.text == "O")
        {

            messageText.text = "jogador O Ganhou";

        }

        
         if (Text4.text == "x" && Text5.text == "x" && Text6.text == "x")
        {

            messageText.text = "jogador X Ganhou";

        }

          if (Text4.text == "O" && Text5.text == "O" && Text6.text == "O")
        {

            messageText.text = "jogador O Ganhou";

        }

         
         

          //Diagonal

       if (Text1.text == "x" && Text5.text == "x" && Text9.text == "x")
        {

            messageText.text = "jogador X Ganhou";

        }

          if (Text1.text == "O" && Text5.text == "O" && Text9.text == "O")
        {

            messageText.text = "jogador O Ganhou";

        }
     
      if (Text3.text == "x" && Text5.text == "x" && Text7.text == "x")
        {

            messageText.text = "jogador X Ganhou";

        }

          if (Text3.text == "O" && Text5.text == "O" && Text7.text == "O")
        {

            messageText.text = "jogador O Ganhou";

        }

         if (Text1.text == "x" && Text5.text == "x" && Text9.text == "x")
        {

            messageText.text = "jogador X Ganhou";

        }

          if (Text1.text == "O" && Text5.text == "O" && Text9.text == "O")
        {

            messageText.text = "jogador O Ganhou";

        }



    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
