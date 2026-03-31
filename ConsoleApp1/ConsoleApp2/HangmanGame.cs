namespace ConsoleApp2;

public class HangmanGame
{
    private readonly string[] _wordBank = { "programming", "Tobias", "Marcus", "ves", "TonyRiad" };
    private string _secretWord;
    private char[] _displayWord;
    private List<char> _incorrectLetters = new();
    public int GuessesLeft { get; private set; } = 10;
    public bool IsGameOver { get; private set; } = false;
    public bool Won { get; private set; } = false;

    public HangmanGame()
    {
        Random rng = new Random();
        _secretWord = _wordBank[rng.Next(_wordBank.Length)].ToLower();
        _displayWord = new char[_secretWord.Length];
        for (int i = 0; i < _displayWord.Length; i++)
        {
            _displayWord[i] = '_';
        }
    }

    public void MakeGuess(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Please enter a letter or a word");
            return;
        }
        input = input.ToLower().Trim();
        if (input.Length > 1)
        {
            HandleWordGuess(input);
        }
        else
        {
            HandleLetterGuess((input[0]));
        }
        CheckWinLoss();
    }

    private void HandleLetterGuess(char letter)
    {
        if (_incorrectLetters.Contains(letter) || new string(_displayWord).Contains(letter))
        {
            Console.WriteLine($"\n--> You already tried '{letter}'! No guess consumed.");
            return;
        }
        bool foundMatch = false;
        for (int i = 0; i < _secretWord.Length; i++)
        {
            if (_secretWord[i] == letter)
            {
                _displayWord[i] = letter;
                foundMatch = true;
            }
        }

        if (!foundMatch)
        {
            _incorrectLetters.Add(letter);
            GuessesLeft--;
        }
    }

    private void HandleWordGuess(string wordGuess)
    {
        if (wordGuess == _secretWord)
            {
            _displayWord = _secretWord.ToCharArray();
            Console.WriteLine("\n*** Correct! You found the word! ***");
            
            }
        else
        {
            GuessesLeft--;
            Console.WriteLine(" Wrong word guess!");
        }
    }

    private void CheckWinLoss()
    {
        if (new string(_displayWord) == _secretWord)
        {
            Won = true;
            IsGameOver = true;
        }
        else if (GuessesLeft == 0)
        {
            IsGameOver = true;
        }
    }
    public void ShowStatus()
    {
        Console.WriteLine($"Word: {string.Join(" ", _displayWord)}");
        Console.WriteLine($"Mistakes: {string.Join(", ", _incorrectLetters)}");
        Console.WriteLine($"Guesses Remaining: {GuessesLeft}");
        
    }
    public string GetSecretWord() => _secretWord;
}
