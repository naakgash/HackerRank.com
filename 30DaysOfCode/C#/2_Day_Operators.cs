using System;

class Result
{
    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        double _mealCost = meal_cost;
        int _tipPercent = tip_percent;
        int _taxPercent = tax_percent;

        double _tip = (_mealCost / 100) * _tipPercent;
        double _tax = (_mealCost / 100) * _taxPercent;

        double _totalCost = _mealCost + _tip + _tax;
        Console.WriteLine(Math.Round(_totalCost));

        Console.ReadKey();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

        int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

        int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

        Result.solve(meal_cost, tip_percent, tax_percent);
    }
}
