using System;
using System.Numerics;
using Fractions;

class FractionProblem {
  static void FMain(string[] args) {
    Console.WriteLine(getSolution("3/4", "add", "3/4"));
    Console.WriteLine(getSolution("1/8", "multiply", "2/2"));
    }

    static String getSolution(String a, String b, String c){
        switch(b){
            case "add":
                return (Fraction.FromString(a) + Fraction.FromString(c)).ToString();
            case "subtract":
                return (Fraction.FromString(a) - Fraction.FromString(c)).ToString();
            case "multiply":
                return (Fraction.FromString(a) * Fraction.FromString(c)).ToString();
            case "divide":
                return (Fraction.FromString(a) / Fraction.FromString(c)).ToString();
            default:
                return "Invalid operator";
        }
       
     }

}