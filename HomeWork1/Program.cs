Console.WriteLine("Please enter your balance:");
decimal balance = Convert.ToDecimal(Console.ReadLine());

while (true) {
    Console.Clear();
    Console.WriteLine($"Your current balance is: {balance:F2}€");
    Console.WriteLine("Please choose option: (withdraw/deposit)");

    string option = Console.ReadLine().ToLower();

    switch(option) {
        case "withdraw":

            Console.WriteLine("You choosed to withdraw money.\nPlease enter amount which you want to widthdraw:");
            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());

            if(withdrawAmount > balance) {
                Console.WriteLine("You do not have enough money to withdraw");
            } else {
                balance -= withdrawAmount;
                Console.WriteLine($"You have widthdrawn {withdrawAmount:F2}€");
                Console.WriteLine($"Your current balance is: {balance:F2}€");
            }

            break;
        case "deposit":

            Console.WriteLine("You choosed to deposit money.\nPlease enter amount which you want to deposit:");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            balance += depositAmount;
            Console.WriteLine($"You have deposited {depositAmount:F2}€");
            Console.WriteLine($"Your current balance is: {balance:F2}€");

            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }

    Console.WriteLine("Do you want to continue? (yes/no)");
    bool doContinue = Console.ReadLine().ToLower() == "yes";

    if(!doContinue) {
        break;
    }
}

Console.WriteLine("Have a nice day :)");