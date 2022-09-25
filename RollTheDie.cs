using System;

public class Player
{
    private Random rnd = new Random();
    
    //roll the d18 die
    public int RollDie() => rnd.Next(1, 18);   

    //random real number between 0.0 and 100.0
    public double GenerateSpellStrength() => rnd.NextDouble() * 100;
    
}
