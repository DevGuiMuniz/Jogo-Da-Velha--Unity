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
     public Text[] texts;

    public bool turnX = true;
    public Text messageText;

    public void ClickButton1()
    {
       if (turnX && Text1.text == "")
        {
            Text1.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
            VictoryCheck();
        }

    }

    public void ClickButton2()
    {
      if (turnX && Text2.text == "")
        {
            Text2.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
            VictoryCheck();
        }
        
    }

    public void ClickButton3()
    {
        if (turnX && Text3.text == "")
        {
            Text3.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
            VictoryCheck();
        }
        
        

    }
    public void ClickButton4()
    {
        if (turnX && Text4.text == "")
        {
            Text4.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
            VictoryCheck();
        }

    }
    public void ClickButton5()
    {
        if (turnX && Text5.text == "")
        {
            Text5.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
            VictoryCheck();
        }

    }

    public void ClickButton6()
    {
        if (turnX && Text6.text == "")
        {
            Text6.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
            VictoryCheck();
        }

    }
    public void ClickButton7()
    {
      if (turnX && Text7.text == "")
        {
            Text7.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
            VictoryCheck();
        }

    }
    public void ClickButton8()
    {

       if (turnX && Text8.text == "")
        {
            Text8.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
            VictoryCheck();
        }
    }

    public void ClickButton9()
    {
        if (turnX && Text9.text == "")
        {
            Text9.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
            VictoryCheck();
        }

    }

    public void VictoryCheck()
{
     if ((Text1.text == "X" && Text5.text == "X" && Text9.text == "X") ||
        (Text3.text == "X" && Text5.text == "X" && Text7.text == "X") ||
        (Text1.text == "X" && Text2.text == "X" && Text3.text == "X") ||
        (Text4.text == "X" && Text5.text == "X" && Text6.text == "X") ||
        (Text7.text == "X" && Text8.text == "X" && Text9.text == "X") ||
        (Text1.text == "X" && Text4.text == "X" && Text7.text == "X") ||
        (Text2.text == "X" && Text5.text == "X" && Text8.text == "X") ||
        (Text3.text == "X" && Text6.text == "X" && Text9.text == "X"))
    {
        messageText.text = "O jogador X venceu!";
    }
    else if ((Text1.text == "O" && Text5.text == "O" && Text9.text == "O") ||
             (Text3.text == "O" && Text5.text == "O" && Text7.text == "O") ||
             (Text1.text == "O" && Text2.text == "O" && Text3.text == "O") ||
             (Text4.text == "O" && Text5.text == "O" && Text6.text == "O") ||
             (Text7.text == "O" && Text8.text == "O" && Text9.text == "O") ||
             (Text1.text == "O" && Text4.text == "O" && Text7.text == "O") ||
             (Text2.text == "O" && Text5.text == "O" && Text8.text == "O") ||
             (Text3.text == "O" && Text6.text == "O" && Text9.text == "O"))
    {
        messageText.text = "O jogador O venceu!";
    }
    else if (Text1.text != "" && Text2.text != "" && Text3.text != "" &&
             Text4.text != "" && Text5.text != "" && Text6.text != "" &&
             Text7.text != "" && Text8.text != "" && Text9.text != "")
    {
        messageText.text = "O jogo empatou";
    }
}

 void AIMove()
    {
       // Lista para armazenar os índices das células vazias
        List<int> emptyCellsIndexes = new List<int>();

        // Encontra as células vazias
        for (int i = 0; i < texts.Length; i++)
        {
            if (texts[i].text == "")
            {
                emptyCellsIndexes.Add(i);
            }
        }

        // Verifica se existem células vazias para jogar
        if (emptyCellsIndexes.Count > 0)
        {
            // Escolhe aleatoriamente um índice das células vazias
            int randomIndex = Random.Range(0, emptyCellsIndexes.Count);
            int cellIndex = emptyCellsIndexes[randomIndex];

            // Coloca "O" na célula escolhida
            texts[cellIndex].text = "O";
            turnX = true;
            messageText.text = "Jogador: X";

            VictoryCheck();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        texts = new Text[] { Text1, Text2, Text3, Text4, Text5, Text6, Text7, Text8, Text9 };
        messageText.text = "Jogador: X"; 
      
    }

    // Update is called once per frame
    void Update()
    {
                  if (!turnX)
        {
            AIMove();
        }
  
    }
}
