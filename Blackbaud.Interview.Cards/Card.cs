namespace Blackbaud.Interview.Cards;

/// <summary>
/// A single card, with a suit and rank
/// </summary>
///
public static class RankExtentions
{
    public static int GetValue(this Rank rank) => rank switch
    {


        Rank.Ace => 11,
        Rank.Two => 2,
        Rank.Three => 3,
        Rank.Four => 4,
        Rank.Five => 5,
        Rank.Six => 6,
        Rank.Seven => 7,
        Rank.Eight => 8,
        Rank.Nine => 9,
        Rank.Ten => 10,
        Rank.Jack => 10,
        Rank.Queen => 10,
        Rank.King => 10,
        _ => throw new InvalidOperationException(),

    };
}
public record Card
{
    /// <summary>
    /// The rank of this card
    /// </summary>
    public Rank Rank { get; init; }

    /// <summary>
    /// The suit of this card
    /// </summary>
    public Suit Suit { get; init; }

    /// <summary>
    /// Creates a new card.
    /// </summary>
    /// <param name="rank"></param>
    /// <param name="suit"></param>
    public Card(Rank rank, Suit suit)
    {
        Rank = rank;
        Suit = suit;
    }

    /// <summary>
    /// Returns a string representation of this card as {Rank} of {Suit}
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }

    /// <summary>
    /// Returns an abbreviated string representation of this card as {R}{S}
    /// </summary>
    /// <returns></returns>
    public string ToShortString()
    {
        var shortRank = Rank.ToShortString();
        var shortSuit = Suit.ToShortString();
        return $"{shortRank}{shortSuit}";
    }

   


}
