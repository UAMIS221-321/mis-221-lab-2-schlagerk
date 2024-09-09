

const double COST_OF_SANDWICH = 4.75; 
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.1;

//sandwiches
int numberOfSandwiches = GetNumberOfSandwiches();
static int GetNumberOfSandwiches()
{
    Console.WriteLine("How many sandwiches?");
    return int.Parse(Console.ReadLine());
}

//toppings 
int numberOfToppings = GetNumberOfToppings();
static int GetNumberOfToppings()
{
    Console.WriteLine("How many toppings?");
    return int.Parse(Console.ReadLine());
}

//tip
double tip = GetTip();
static double GetTip()
{
    Console.WriteLine("How much tip?");
    return double.Parse(Console.ReadLine());
}

double totalSandwichCost = GetTotalSandwichCost(numberOfSandwiches, COST_OF_SANDWICH);
static double GetTotalSandwichCost(int numberOfSandwiches, double COST_OF_SANDWICH)
{
    return numberOfSandwiches * COST_OF_SANDWICH;
}

double totalToppingCost = GetTotalToppingCost(numberOfToppings, COST_OF_TOPPING);
static double GetTotalToppingCost(int numberOfToppings, double COST_OF_TOPPING)
{
    return numberOfToppings * COST_OF_TOPPING;
}

double baseCost = GetBaseCost(totalSandwichCost, totalToppingCost);
static double GetBaseCost(double totalSandwichCost, double totalToppingCost)
{
    return totalSandwichCost + totalToppingCost;
}

double orderCost = tip + baseCost * (1 - DISCOUNT_AMOUNT);

Math.Round(orderCost,2);

    System.Console.WriteLine("The order cost is "+orderCost);
