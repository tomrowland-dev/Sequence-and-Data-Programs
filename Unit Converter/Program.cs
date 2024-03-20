Console.WriteLine("How many millimeters would you like to convert? ");
double toConvert = Convert.ToDouble(Console.ReadLine());


void Calculate(double numberToConvert){
  
  double centimetres = numberToConvert / 10;
  double meters = centimetres / 100;
  double kilometers = meters / 1000;
  double inches = centimetres / 2.54;
  double feet = inches / 12;
  double miles = feet / 5280;

  Console.WriteLine($"Centimeters: {centimetres}");
  Console.WriteLine($"Meters: {meters}");
  Console.WriteLine($"Kilometers: {kilometers}");
  Console.WriteLine($"Inches: {inches}");
  Console.WriteLine($"Feet: {feet}");
  Console.WriteLine($"Miles: {miles}");

};

Calculate(toConvert);
Console.WriteLine("Press any key to exit.");
Console.ReadKey();
