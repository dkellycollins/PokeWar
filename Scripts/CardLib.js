Suit = {
	CLUB : 0,
	SPADE: 1,
	HEART: 2,
	DIAMOND: 3,
	JOKER: 4,
	GetSuitByValue = function(value) {
		switch(value) {
			case 0:
				return CLUB;
			case 1:
				return SPADE;
			case 2:
				return HEART;
			case 3:
				return DIAMOND;
			case 4:
				return JOKER;
		}
	}
}

function Card(suit, value) {
	this.Suit = suit;
	this.Value = value;
	this.Faceup = false;
	
	this.ToString = function() {
		//Return the string representation of the card.
	}
}

function Deck() {
	this.Cards = [];
	this.index = 0;
	
	//Create all 54 cards.
	for(int i = 0; i < 5; i++) {
		for(int j = 1; j <= 14; j++) {
			Cards.append(new Card(Suit.GetSuitByValue(i), j));
		}
	}
	
	//Returns a the given number of cards from the deck.
	this.Draw = function(numOfCards) {
		return Cards[index++];
	}
	
	//Returns the card with the given suit and value from the deck.
	//If suit is null, then this will return all cards with the given value.
	//If value is null, then this will return all cards with the given suit.
	this.DrawCard = function(suit, value) {
		if(!suit) {
			//Return all cards with the given value.
		}
		else if(!value) {
			//Return all cards with the given suit.
		}
		else {
			//Return the card that has the given suit and value.
		}
	}
	
	//Shuffles the order of the cards.
	this.Shuffle() {
		//Shuffle the order of Cards.
	}
	
	//Removes the card with the given suit an value from the deck.
	//If suit is null then this will return all cards with the given value.
	//If value is null then this will return all cards with the given suit.
	//All cards removed will be returned.
	this.RemoveFromPlay(suit, value) {
		if(!suit) {
			//Remove and return all cards with the given value.
		}
		else if(!value) {
			//Remove and return all cards with the given suit.
		}
		else {
			//Remove and return the card with the given suit and value.
		}
	}
	
	//Returns all cards to the deck.
	this.Reset = function() {
		index = 0;
		for(card in Cards) {
			card.Faceup = false;
		}
	}
	
	//Returns the number of cards still in play.
	this.CardsRemaining() {
		return Cards.length - index;
	}
}