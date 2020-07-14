using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
       
            public string IsApalindrom(string word)
            {
            //revers the word//hello/olleh
            var reversed = "";
            char[] wordArray = word.ToCharArray();//char[] name = new char[]();
            char[] newArray = wordArray;
            for (int i = word.Length-1; i >= 0; i--)
            {
                reversed += word[i];
            }
            return reversed;
                //compare the original with the reversed
              //  if (reversed.ToLower() == word.ToLower())
           // {
            //    return true;
          //  }
           // else
           // {
           //     return false;
          // }
                //return whether they are the same or not

            
            }
    
        
    }


}
