Dictionary<string,int> coins = new Dictionary<string, int>()
{
  {"$2", 200},
  {"$1", 100},
  {"$0.50", 50},
  {"$0.20", 20},
  {"$0.10", 10},
  {"$0.05", 5},
};

Console.WriteLine("How much did the item cost (in cents)?");

string itemCostStr = Console.ReadLine();

Console.WriteLine("How much did you pay (in cents)?");

string amountPaidStr = Console.ReadLine();

if (itemCostStr == "")
{
  itemCostStr = "0";
}; 

if (amountPaidStr == "")
{
  amountPaidStr = "0";
}

int itemCostInt = Convert.ToInt32(itemCostStr);
int amountPaidInt = Convert.ToInt32(amountPaidStr);

int changeRequired = amountPaidInt - itemCostInt;
int changeToGiveOfType;

void CalculateChange() {
  foreach (var coin in coins)
  {
    changeToGiveOfType = changeRequired / coin.Value;
    Console.WriteLine($"{changeToGiveOfType} x {coin.Key} owed." );
    changeRequired -= (changeToGiveOfType*coin.Value);
  }
}

CalculateChange();





