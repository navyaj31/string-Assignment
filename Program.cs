//(A)shortest word of thr array
Console.WriteLine("Enter the number of words: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] words = new string[n];
Console.WriteLine("Enter the words: ");
for (int i = 0; i < n; i++)
{
    words[i] = Console.ReadLine();
}

string shortest = words[0];
for (int i = 1; i < n; i++)
{
    if (words[i].Length < shortest.Length)
    {
        shortest = words[i];
    }
}

Console.WriteLine($"The shortest word is: {shortest}");



//(B)finding the word is already present in the string

Console.WriteLine("Enter a word to search:");
string word = Console.ReadLine();
char res = 'n';

for (int i = 0; i < n; i++)
{
    if (word.Equals(words[i], StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("The word " + word + " is present in the list");
        res = 'y';
        break;
    }
}
if(res == 'n')
    {
        Console.WriteLine("The word " + word + " is not present in the list");
    }




//(C)Sort in alphabetical order


Array.Sort(words);
Console.WriteLine(" The Sorted Array is:");
foreach (String str in words)
{
    Console.WriteLine(str);
}





//(D)Palindrome

int count = 0;

string[] palindrome_words = new string[n];



for (int i = 0; i < n; i++)

{

    string current_word = words[i];

    Char[] arr = current_word.ToCharArray();

    for (int j = 0; j < current_word.Length / 2; j++)

    {

        char temp = arr[j];

        arr[j] = arr[current_word.Length - j - 1];

        arr[current_word.Length - j - 1] = temp;

    }

    string reversed = new string(arr);

    if (reversed.Equals(words[i], StringComparison.OrdinalIgnoreCase))

    {

        count++;

        palindrome_words[count - 1] = words[i];

    }

}



Console.WriteLine($"The number of palindromes in the list are : {count}");

foreach (string str in palindrome_words)

{

    Console.WriteLine(str);

}



