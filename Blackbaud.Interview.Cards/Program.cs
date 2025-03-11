namespace Blackbaud.Interview.Cards;

public static class Program
{
    static void Main()
    {
        // Part 1 Create a new deck and deal out all the cards

        Console.WriteLine("**********");
        Console.WriteLine("Part 1 - Create a new deck, shuffle, then deal out all the cards");

        var deck = Deck.NewDeck();
        deck.Shuffle(5);

        var card1 = deck.NextCard();
        var card2 = deck.NextCard();

        Console.WriteLine($" Drawn Cards: {card1.ToShortString()} - {card1}, {card2.ToShortString()} - {card2}");

        int sum = card1.Rank.GetValue() + card2.Rank.GetValue();
        if (sum == 21)
        {
            Console.WriteLine($"Drawn Cards: {card1.ToShortString()} and {card2.ToShortString()} are BlackJack ");

        }
        else
        {
            Console.WriteLine($" Total Sum of cards : {sum} ");
        }


        //int numPlayers = 6;
        //int cardsPerPlayer = 10;
        //int totalCardsNeeded = numPlayers * cardsPerPlayer;

        //if (totalCardsNeeded> deck.RemainingCards)
        //{
        //    Console.WriteLine($"Not enough cardsto deal {cardsPerPlayer} cards to {numPlayers} players ");

        //    cardsPerPlayer = deck.RemainingCards/numPlayers;
        //    Console.WriteLine($"Adjusting to {cardsPerPlayer} cards per player");
        //}



        //List<List<Card>> playerHands = new List<List<Card>>();
        //for(int i =0; i<numPlayers; i++)
        //{
        //    playerHands.Add(new List<Card>());
        //}

        //for (int i = 0; i < cardsPerPlayer; i++)
        //{
        //    for(int j = 0; j < numPlayers; j++)
        //    {
        //        if (!deck.Empty)
        //        {
        //            playerHands[j].Add(deck.NextCard());

        //        }
        //    }
        //}

        ////to display player'hand

        //for(int i = 0;i < numPlayers; i++)
        //{
        //    Console.WriteLine($"Player {i + 1}'s hand : {string.Join(",", playerHands[i].Select(card => card.ToShortString()))}");
        //}


        // Create a new deck
        //var deck = Deck.NewDeck();

        // TODO: shuffle the deck
        //Console.WriteLine("Shuffling...");
        //Console.Write("Enter the number of times to shuffle the deck: ");
        //if (int.TryParse(Console.ReadLine(), out int shuffleCount) && shuffleCount > 0)
        //{
        //    deck.Shuffle(shuffleCount);
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input. Deck will not be shuffled.");
        //}

        //Console.WriteLine("Shuffling... Done!");
        //// Deal all the cards
        //while (!deck.Empty)
        //{
        //    var card = deck.NextCard();
        //    Console.WriteLine($"{card.ToShortString()} - {card}");
        //}

        Console.WriteLine();
        Console.WriteLine("**********");
        Console.WriteLine();
    }
}
