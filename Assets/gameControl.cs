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
            Text1.text = "★";
            turnX = false;
            messageText.text = "Jogador: ♥";
            VictoryCheck();
        }
    }

    public void ClickButton2()
    {
        if (turnX && Text2.text == "")
        {
            Text2.text = "★";
            turnX = false;
            messageText.text = "Jogador: ♥";
            VictoryCheck();
        }
    }

    public void ClickButton3()
    {
        if (turnX && Text3.text == "")
        {
            Text3.text = "★";
            turnX = false;
            messageText.text = "Jogador: ♥";
            VictoryCheck();
        }
    }

    public void ClickButton4()
    {
        if (turnX && Text4.text == "")
        {
            Text4.text = "★";
            turnX = false;
            messageText.text = "Jogador: ♥";
            VictoryCheck();
        }
    }

    public void ClickButton5()
    {
        if (turnX && Text5.text == "")
        {
            Text5.text = "★";
            turnX = false;
            messageText.text = "Jogador: ♥";
            VictoryCheck();
        }
    }

    public void ClickButton6()
    {
        if (turnX && Text6.text == "")
        {
            Text6.text = "★";
            turnX = false;
            messageText.text = "Jogador: ♥";
            VictoryCheck();
        }
    }

    public void ClickButton7()
    {
        if (turnX && Text7.text == "")
        {
            Text7.text = "★";
            turnX = false;
            messageText.text = "Jogador: ♥";
            VictoryCheck();
        }
    }

    public void ClickButton8()
    {
        if (turnX && Text8.text == "")
        {
            Text8.text = "★";
            turnX = false;
            messageText.text = "Jogador: ♥";
            VictoryCheck();
        }
    }

    public void ClickButton9()
    {
        if (turnX && Text9.text == "")
        {
            Text9.text = "★";
            turnX = false;
            messageText.text = "Jogador: ♥";
            VictoryCheck();
        }
    }

    public void AIMove()
    {
        // Estratégia para bloquear as jogadas do jogador
        for (int i = 0; i < texts.Length; i++)
        {
            if (texts[i].text == "")
            {
                // Simula a jogada do jogador e verifica se o jogador ganharia na próxima jogada
                texts[i].text = "♥";
                if (CheckForWin("♥"))
                {
                    texts[i].text = "♥"; // Bloqueia a jogada do jogador
                    turnX = true;
                    messageText.text = "Jogador: ★";
                    VictoryCheck();
                    return;
                }
                else
                {
                    texts[i].text = ""; // Desfaz a simulação
                }
            }
        }

        // Estratégia para buscar uma vitória iminente
        for (int i = 0; i < texts.Length; i++)
        {
            if (texts[i].text == "")
            {
                // Simula a jogada da IA e verifica se ela ganharia na próxima jogada
                texts[i].text = "★";
                if (CheckForWin("★"))
                {
                    texts[i].text = "♥"; // Faz a jogada da IA para ganhar o jogo
                    turnX = true;
                    messageText.text = "Jogador: ★";
                    VictoryCheck();
                    return;
                }
                else
                {
                    texts[i].text = ""; // Desfaz a simulação
                }
            }
        }

        // Se nenhuma estratégia for possível, escolhe uma posição aleatória
        List<int> emptyCellsIndexes = new List<int>();
        for (int i = 0; i < texts.Length; i++)
        {
            if (texts[i].text == "")
            {
                emptyCellsIndexes.Add(i);
            }
        }

        if (emptyCellsIndexes.Count > 0)
        {
            int randomIndex = Random.Range(0, emptyCellsIndexes.Count);
            int cellIndex = emptyCellsIndexes[randomIndex];
            texts[cellIndex].text = "♥";
            turnX = true;
            messageText.text = "Jogador: ★";
            VictoryCheck();
        }
    }

    public bool CheckForWin(string player)
    {
        if ((Text1.text == player && Text5.text == player && Text9.text == player) ||
            (Text3.text == player && Text5.text == player && Text7.text == player) ||
            (Text1.text == player && Text2.text == player && Text3.text == player) ||
            (Text4.text == player && Text5.text == player && Text6.text == player) ||
            (Text7.text == player && Text8.text == player && Text9.text == player) ||
            (Text1.text == player && Text4.text == player && Text7.text == player) ||
            (Text2.text == player && Text5.text == player && Text8.text == player) ||
            (Text3.text == player && Text6.text == player && Text9.text == player))
        {
            return true;
        }
        return false;
    }

    public void VictoryCheck()
    {
        if (CheckForWin("★"))
        {
            messageText.text = "O jogador ★ venceu!";
        }
        else if (CheckForWin("♥"))
        {
            messageText.text = "O jogador ♥ venceu!";
        }
        else if (Text1.text != "" && Text2.text != "" && Text3.text != "" &&
                 Text4.text != "" && Text5.text != "" && Text6.text != "" &&
                 Text7.text != "" && Text8.text != "" && Text9.text != "")
        {
            messageText.text = "O jogo empatou";
        }
    }

    void Start()
    {
        texts = new Text[] { Text1, Text2, Text3, Text4, Text5, Text6, Text7, Text8, Text9 };
        messageText.text = "Jogador: ★";
    }

    void Update()
    {
        if (!turnX)
        {
            AIMove();
        }
    }
}