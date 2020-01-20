﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        bool turn = true; //True x ; false o
        int count = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
            {
                button.Content = "X";
                button.IsEnabled = false;
            }
            else
            {
                button.Content = "O";
                button.IsEnabled = false;
            }
            turn = !turn;
            count++;
            klasa.IsWin();


        }
        public void IsWin()
        {
            bool isWiner = false;
            //row checking
            if ((!A1.IsEnabled) && A1.Content.Equals(A2.Content) && A2.Content.Equals(A3.Content) && A3.Content.Equals(A4.Content) && A3.Content.Equals(A4.Content) && A4.Content.Equals(A5.Content))
                isWiner = true;
            if ((!B1.IsEnabled) && B1.Content.Equals(B2.Content) && B2.Content.Equals(B3.Content) && B3.Content.Equals(B4.Content) && B3.Content.Equals(B4.Content) && B4.Content.Equals(B5.Content))
                isWiner = true;
            if ((!C1.IsEnabled) && C1.Content.Equals(C2.Content) && C2.Content.Equals(C3.Content) && C3.Content.Equals(C4.Content) && C3.Content.Equals(C4.Content) && C4.Content.Equals(C5.Content))
                isWiner = true;
            if ((!D1.IsEnabled) && D1.Content.Equals(D2.Content) && D2.Content.Equals(D3.Content) && D3.Content.Equals(D4.Content) && D3.Content.Equals(D4.Content) && D4.Content.Equals(D5.Content))
                isWiner = true;
            if ((!E1.IsEnabled) && E1.Content.Equals(E2.Content) && E2.Content.Equals(E3.Content) && E3.Content.Equals(E4.Content) && E3.Content.Equals(E4.Content) && E4.Content.Equals(E5.Content))
                isWiner = true;
            //Column checking
            if ((!A1.IsEnabled) && A1.Content.Equals(B1.Content) && B1.Content.Equals(C1.Content) && C1.Content.Equals(D1.Content) && D1.Content.Equals(E1.Content))
                isWiner = true;
            if ((!A2.IsEnabled) && A2.Content.Equals(B2.Content) && B2.Content.Equals(C2.Content) && C2.Content.Equals(D2.Content) && D2.Content.Equals(E2.Content))
                isWiner = true;
            if ((!A3.IsEnabled) && A3.Content.Equals(B3.Content) && B3.Content.Equals(C3.Content) && C3.Content.Equals(D3.Content) && D3.Content.Equals(E3.Content))
                isWiner = true;
            if ((!A4.IsEnabled) && A4.Content.Equals(B4.Content) && B4.Content.Equals(C4.Content) && C4.Content.Equals(D4.Content) && D4.Content.Equals(E4.Content))
                isWiner = true;
            if ((!A5.IsEnabled) && A5.Content.Equals(B5.Content) && B5.Content.Equals(C5.Content) && C5.Content.Equals(D5.Content) && D5.Content.Equals(E5.Content))
                isWiner = true;
            //Cross checking
            if ((!A1.IsEnabled) && A1.Content.Equals(B2.Content) && B2.Content.Equals(C3.Content) && C3.Content.Equals(D4.Content) && D4.Content.Equals(E5.Content))
                isWiner = true;
            if ((!E1.IsEnabled) && E1.Content.Equals(D2.Content) && D2.Content.Equals(C3.Content) && C3.Content.Equals(B4.Content) && B4.Content.Equals(A5.Content))
                isWiner = true;

            if (isWiner)
            {
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " has won the game!");
                ButtonDisabled();
            }
            else if (!isWiner && count == 25)
            {
                MessageBox.Show("DRAW!");
                ButtonDisabled();
            }

        }
        void ButtonDisabled()
        {
            A1.IsEnabled = false;
            A2.IsEnabled = false;
            A3.IsEnabled = false;
            A4.IsEnabled = false;
            A5.IsEnabled = false;
            B1.IsEnabled = false;
            B2.IsEnabled = false;
            B3.IsEnabled = false;
            B4.IsEnabled = false;
            B5.IsEnabled = false;
            C1.IsEnabled = false;
            C2.IsEnabled = false;
            C3.IsEnabled = false;
            C4.IsEnabled = false;
            C5.IsEnabled = false;
            D1.IsEnabled = false;
            D2.IsEnabled = false;
            D3.IsEnabled = false;
            D4.IsEnabled = false;
            D5.IsEnabled = false;
            E1.IsEnabled = false;
            E2.IsEnabled = false;
            E3.IsEnabled = false;
            E4.IsEnabled = false;
            E5.IsEnabled = false;

        }
    }
}