using Claw_Machine2;

while (true)
{
    ClawMachine.Play();
    Console.WriteLine("Try Again? (y/n)");
    string response = Console.ReadLine().ToLower();
    if(response == "y")
    {

    }
    else
    {
        break;
    }
}