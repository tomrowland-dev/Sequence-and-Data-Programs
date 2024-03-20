const double STROUHAL_LOW_EFFICIENCY = 0.4;
const double STROUHAL_HIGH_EFFICIENCY = 0.2;

Console.WriteLine("What is the name of the bird?");
string birdName = Console.ReadLine();

Console.WriteLine("What is the frequency of the birds wingstroke? (in BPS)");
string freqStr = Console.ReadLine();

Console.WriteLine("What is the amplitude of the bird? (in meters) ");
string ampStr = Console.ReadLine();

void CalculateAirspeed(string freq, string amp)
{
    double frequency = Convert.ToDouble(freq);
    double amplitude = Convert.ToDouble(amp);

    double resultMax = frequency * amplitude / STROUHAL_HIGH_EFFICIENCY;
    double resultMin = frequency * amplitude / STROUHAL_LOW_EFFICIENCY;

    Console.WriteLine($"The {birdName} has a minimum airspeed of {resultMin}, and a maximum airspeed of {resultMax}. ");
}

CalculateAirspeed(freqStr, ampStr);