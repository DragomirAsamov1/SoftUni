﻿using System;

namespace StringExplosion {
    internal class Program {
        static void Main(string[] args) {
            string text = Console.ReadLine();

            int power = 0;

            for (int i = 0; i < text.Length; i++) {
                if (text[i] == '>') {
                    power += int.Parse(text[i + 1].ToString());
                    continue;
                } 
                
                if (power > 0) {
                    text = text.Remove(i, 1);
                    power--;
                    i--;
                }
            }

            Console.WriteLine(text);
            
        }
    }
}
