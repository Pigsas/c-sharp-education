

Console.WriteLine("How many names you want to store ?");
int count = Convert.ToInt32(Console.ReadLine());
List<string> listOfNames = new List<string>(count);


for (int i = 0; i < count; i++) {
    Console.WriteLine("Enter name:");
    listOfNames.Add(Console.ReadLine());
} 

Console.WriteLine("Name list was generated:");
foreach(string name in listOfNames) {
    Console.WriteLine(name);
}

//-------------------------------------------------------------

Console.WriteLine("This is maximum number finder");
Console.WriteLine("How many number you want to input ?");
int count2 = Convert.ToInt32(Console.ReadLine());
List<int> listOfNumbers = new List<int>(count);

for (int i = 0; i < count; i++) {
    Console.WriteLine("Enter number:");
    listOfNumbers.Add(Convert.ToInt32(Console.ReadLine()));
} 

int max = listOfNumbers[0];
foreach (int number in listOfNumbers) {
    if (number > max) {
        max = number;
    }
}

Console.WriteLine($"Maximum number is {max}");

//-------------------------------------------------------------

List<int> listOfNumbers2 = new List<int>();
List<int> listOfEvenNumber = new List<int>();
Random random = new Random();

for (int i = 0; i < 20; i++) {
    listOfNumbers2.Add(random.Next());
}

foreach (int number in listOfNumbers2) {
    if(number % 2 == 0) {
        listOfEvenNumber.Add(number);
    }
}

Console.WriteLine("List of even numbers");0
foreach(int number in listOfEvenNumber) {
    Console.WriteLine(number);
}

