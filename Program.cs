// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        //Added a new array of Card objects, initialized with specific card values and suits.
        Card[] myCardsArray = new Card[]
        {
            new Card("A", "Spades"),
            new Card("J", "Clubs"),
            new Card("Q", "Diamonds"),
            new Card("Q", "Hearts"),
            new Card("10", "Hearts"),
            new Card("2", "Diamonds"),
            new Card("6", "Spades"),
            new Card("9", "Clubs"),
            new Card("A", "Diamonds"),
        };

        //initializes a stack of Card objects named "startingDeck" with the elements from the "myCardsArray" array.
        Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

        //Added code to print each card's number and suit in the "startingDeck" collection to the console.
        Console.WriteLine("Cards in Deck:");
        foreach (Card card in startingDeck)
        {
            Console.WriteLine($"The {card.Number} of {card.Suit}!");
        }

        //prints the number of cards in the "startingDeck" list and initializes "myHand" as a list of Card objects containing three specific cards.
        Console.WriteLine($"Cards in the stack: {startingDeck.Count}");
        List<Card> myHand = new List<Card>();
        myHand.Add(new Card("Jack", "Diamonds"));
        myHand.Add(new Card("8", "Hearts"));
        myHand.Add(new Card("3", "Diamonds"));

        //"Got any 8's?" to the console and adds a card from the startingDeck to myHand if startingDeck is not empty.
        Console.WriteLine("Got any 8's?");
        if (startingDeck.Count > 0)
        {
            myHand.Add(startingDeck.Pop());
        }

        //display the count of cards in the "startingDeck" stack using the Console.WriteLine method with string interpolation.
        Console.WriteLine($"Cards in the stack: {startingDeck.Count}");

        //commits to transferring the first card from the "myHand" list to the "startingDeck" stack while removing it from the original hand.
        startingDeck.Push(myHand[0]);
        myHand.RemoveAt(0);

        //iterates through a collection of "Card" objects called "startingDeck" and prints out each card's number and suit using a formatted string.
        Console.WriteLine("Cards in Deck:");
        foreach (Card card in startingDeck)
        {
            Console.WriteLine($"The {card.Number} of {card.Suit}!");
        }
    }
}