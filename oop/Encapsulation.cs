// Encapsulation  involves bundling data(attributes) and methods(functions) that operate
// on the data into a single unit, called a class.
class Encapsulation // Bank Account
{
    // Private field (data hiding)
    private decimal _balance;

    // Public method to deposit money (encapsulation)
    public void Deposit(decimal amount)
    {
        // Update the balance (data hiding)
        _balance += amount;
    }

    // Public method to withdraw money (encapsulation)
    public void Withdraw(decimal amount)
    {
        // Check if sufficient balance before withdrawing (data hiding)
        if (_balance >= amount)
        {
            // Update the balance (data hiding)
            _balance -= amount;
            Console.WriteLine($"Withdrawn {amount}. Remaining balance: {_balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }





}




