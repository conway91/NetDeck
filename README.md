# NetDeck

![alt text](https://travis-ci.org/conway91/NetDeck.svg?branch=master "NetDeck Build Status")

NetDeck is a dot net library that can be used to created a virtual deck of playing cards. This can be used in projects that require a deck of standard playing cards (e.g. A blackjack game) that can be drawn, shuffled, and re-populated.

Each playing card has a suit, a rank, a rank position (compared to the other cards), and a value, these cards can be used in a variatey of different card games

## Installing
NetDeck is build on .NET Standard 1.0 and should compatable with all .NET projects and versions.

To use NetDeck in your solution download the NuGet package via Visual Studio's package manager (search for 'NetDeck') or run the following line to get the most recent version

```
Install-Package NetDeck
```

## Example usage (c#):
```csharp
    //// Once the package is installed include this in your using
    using NetDeck;

    //// Creating the deck (this creates a deck of 52 playing cards and shuffles them)
    var deck =  new StandardDeck(); 
    
    //// Draw a card, this takes the first card in the deck and removes it from the list
    var drawnCard = deck.DrawCard();
    
    //// Count how many cards still in the current deck
    var currentCount = deck.CurrentCardCount();
    
    //// Refresh (reshuffle) The deck. This refreshes the deck back to its original card count
    deck.RefeshDeck();
```
