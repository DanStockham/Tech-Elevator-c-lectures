using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestableClasses.Classes
{
    public class StringExercises
    {



        /*
         Given two strings, a and b, return the result of putting them together in the order abba, 
         e.g. "Hi" and "Bye" returns "HiByeByeHi".
         makeAbba("Hi", "Bye") → "HiByeByeHi"	
         makeAbba("Yo", "Alice") → "YoAliceAliceYo"	
         makeAbba("What", "Up") → "WhatUpUpWhat"	
         */
        public string MakeAbba(string a, string b)
        {
            return a + b + b + a;
        }

        /*
         Given an "out" string length 4, such as "<<>>", and a word, return a new string where the word is in the 
         middle of the out string, e.g. "<<word>>". Note: use str.Substring(i, j) to extract the string starting 
         at index i and going up to but not including index j.
         makeOutWord("<<>>", "Yay") → "<<Yay>>"	
         makeOutWord("<<>>", "WooHoo") → "<<WooHoo>>"	
         makeOutWord("[[]]", "word") → "[[word]]"	
        */
        public string MakeOutWord(string output, string word)
        {
            return output.Substring(0, 2) + word + output.Substring(2);
        }

        /*
         Given a string, return the string made of its first two chars, so the string "Hello" yields "He". If the 
         string is shorter than length 2, return whatever there is, so "X" yields "X", and the empty string "" 
         yields the empty string "". Note that str.Length returns the length of a string.
         firstTwo("Hello") → "He"	
         firstTwo("abcdefg") → "ab"	
         firstTwo("ab") → "ab"	
         */
        public string FirstTwo(string str)
        {
            if (str.Length < 2)
            {
                return str;
            }
            else
            {
                return str.Substring(0, 2);
            }
        }

    }
}
