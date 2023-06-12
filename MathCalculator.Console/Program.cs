using System.Numerics;

var isGameOn = true;

do
{
    ShowMenu();
    var selection = Console.ReadLine();
    Console.Clear();
    switch (selection.Trim().ToLower())
    {
        case "h":
            ShowHistory(); break;
        case "a":
            StartAdditionGame(); break;
        case "b":
            StartSubtractionGame(); break;
        case "c":
            StartMultiplicationGame(); break;
        case "d":
            StartDivisionGame(); break;
        case "e":
            QuitProgram();
            break;
        default:
            Console.WriteLine("Λάθος επιλογή. Πιέστε οποιοδήποτε πλήκρο για επιστοφή στο αρχικό μενού.");
            Console.ReadKey();
            break;
    }
} while (isGameOn);

void QuitProgram()
{
    Console.Clear();
    Console.WriteLine(""" "Υπολογίζουμε" να σε ξαναδούμε!""");
    Console.ReadKey();
    isGameOn = false;
}

void StartDivisionGame()
{
    int score = 0;


    for (int i = 0; i < 5; i++)
    {
        var (num1, num2) = GetTwoRandomIntegersForDivision(1, 99);

        Console.WriteLine($"{num1} * {num2}");

        var isInt = int.TryParse(Console.ReadLine(), out int numInput);
        if (isInt && num1 * num2 == numInput)
        {
            score++;
        }
        if(!isInt)
        {
            Console.WriteLine("Ουπς! Το αποτέλεσμα είναι πάντα αριθμός!");
            Console.ReadKey();
        }
        Console.Clear();
    }
    Console.WriteLine($"Συνολικό σκόρ: {score} / 5");
}

void StartMultiplicationGame()
{
    int score = 0;


    for (int i = 0; i < 5; i++)
    {
        var (num1, num2) = GetTwoRandomIntegers(1, 99);

        Console.WriteLine($"{num1} * {num2}");

        var isInt = int.TryParse(Console.ReadLine(), out int numInput);
        if (isInt && num1 * num2 == numInput)
        {
            score++;
        }
        if(!isInt)
        {
            Console.WriteLine("Ουπς! Το αποτέλεσμα είναι πάντα αριθμός!");
            Console.ReadKey();
        }
        Console.Clear();
    }
    Console.WriteLine($"Συνολικό σκόρ: {score} / 5");
}

void StartSubtractionGame()
{
    int score = 0;
    

    for (int i = 0; i < 5; i++)
    {
        var (num1, num2) = GetTwoRandomIntegers(1, 99);

        Console.WriteLine($"{num1} - {num2}");

        var isInt = int.TryParse(Console.ReadLine(), out int numInput);
        if (isInt && num1 - num2 == numInput)
        {
            score++;
        }
if(!isInt)        {
            Console.WriteLine("Ουπς! Το αποτέλεσμα είναι πάντα αριθμός!");
            Console.ReadKey();
        }
        Console.Clear();
    }
    Console.WriteLine($"Συνολικό σκόρ: {score} / 5");
}

void StartAdditionGame()
{
    int score = 0;
    

    for (int i = 0; i < 5; i++)
    {

        var (num1, num2) = GetTwoRandomIntegers(1, 99);

        Console.WriteLine($"{num1} + {num2}");

        var isInt = int.TryParse(Console.ReadLine(), out int numInput);
        if (isInt && num1 + num2 == numInput)
        {
            score++;
        }
        if(!isInt)
        {
            Console.WriteLine("Ουπς! Το αποτέλεσμα είναι πάντα αριθμός!");
            Console.ReadKey();
        }
        Console.Clear();
    }
    Console.WriteLine($"Συνολικό σκόρ: {score} / 5");

}

(int num1, int num2) GetTwoRandomIntegers(int minValue, int maxValue)
{
    var random = new Random();
    var num1 = random.Next(minValue, maxValue);
    var num2 = random.Next(minValue, maxValue);
    return (num1,  num2);
}

(int num1, int num2) GetTwoRandomIntegersForDivision(int minValue, int maxValue)
{
    var random = new Random();
    var num1 = random.Next(minValue, maxValue);
    var num2 = random.Next(minValue, maxValue);

    if (num1 % num2 != 0)
    {
        return GetTwoRandomIntegersForDivision(minValue, maxValue);
    }
    return (num1,  num2);
}


void ShowHistory()
{
    throw new NotImplementedException();
}

void ShowMenu()
{
    Console.Clear();
    var menuMessage = @"Διάλεξε μία μαθηματική πράξη για να παίξεις:
H - Ιστορικό
A - Πρόσθεση
B - Αφαίρεση
C - Πολλαπλασιασμός
D - Διαίρεση
E - Έξοδος";
    Console.WriteLine(menuMessage);
}