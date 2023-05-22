
//string myString = "Hello, world!";
//int stringLength = myString.Length;

//Console.WriteLine(stringLength);

//Console.WriteLine(myString.Length);

Console.WriteLine("Enter your first name:");
string userName = Console.ReadLine().Trim();
Console.WriteLine(userName.Length);
Console.WriteLine($"The last letter in your name is: {userName[userName.Length - 1]}");

int counter = 0;

for (int i = 0; i < userName.Length; i++)
{
    if (userName[i] == 'a')
        counter++;
}

Console.WriteLine($"Your first name has {counter} 'a' occurences.");

string updatedUserName = userName.Replace('a', '4');
Console.WriteLine(updatedUserName);