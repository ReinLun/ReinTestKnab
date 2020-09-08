Feature: WorkWithCardsOnTrello
	Create a card on a existing Trello Board
	Read the new card on a existing Trello Board
	Update the new card on a existing Trello Board
	Delete the new card on a existing Trello Board

@smoke
Scenario: Tester Works with cards
	Given the tester create a card
	Then the tester reads the new card
	Then the tester updates the new card
	Then the tester delete the new card
	And  the card does not exists anymore