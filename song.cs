using Internal;
using System;
using System.Linq;
namespace Song
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a string:");
            string input = Console.ReadLine();
            Console.WriteLine("\n" + Song(input));
        }

        public static string Song(string s)
        {
            string vowels = "aeiouy";
            string temp = "";
            string consonants = new string(s.Where(c => !vowels.Contains(c)).Distinct().ToArray()).ToUpperInvariant();
            consonants = consonants.Replace(" ", "");
            foreach (char c in consonants)
            {
                temp += $"{c}-A: {c}ay \n{c}-E: {c}ee \n{c}-I: {c}icky-{c}ie \n{c}-O: {c}o \n{c}icky-{c}ie {c}o, {c}-U: {c}oo \n{c}icky-{c}ie {c}o {c}oo!\n\n";
            }
            return temp;
        }
    }
}
/*
T-A: Tay 
T-E: Tee 
T-I: Ticky-Tie 
T-O: To 
Ticky-Tie To, T-U: Too 
Ticky-Tie To Too!

H-A: Hay 
H-E: Hee 
H-I: Hicky-Hie 
H-O: Ho 
Hicky-Hie Ho, H-U: Hoo 
Hicky-Hie Ho Hoo!

R-A: Ray 
R-E: Ree 
R-I: Ricky-Rie 
R-O: Ro 
Ricky-Rie Ro, R-U: Roo 
Ricky-Rie Ro Roo!

S-A: Say 
S-E: See 
S-I: Sicky-Sie 
S-O: So 
Sicky-Sie So, S-U: Soo 
Sicky-Sie So Soo!

G-A: Gay 
G-E: Gee 
G-I: Gicky-Gie 
G-O: Go 
Gicky-Gie Go, G-U: Goo 
Gicky-Gie Go Goo!
*/
