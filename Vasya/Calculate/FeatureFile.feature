Feature: FeatureFile
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario: Vasya and friends drinking water
	Given Vasya have 100 liters of water
	And Vasya have 4 friends
	When Vasya drinking 3 liters/day and every friend drinking 4 liters/day for week
	Then Vasya will have -33 liters of water 

Scenario: Vasya drinking water and eating apples alone
	Given Vasya have 100 liters of water
	And Vasya have 27 apples
	When Vasya drinking 3 liters/day and eating 3 apples/day for week
	Then Vasya will have 79 liters of water and 6 apples

Scenario: Vasya drinking water and eating apples with friends
	Given Vasya have 100 liters of water
	And Vasya have 27 apples
	And Vasya have 4 friends
	When Vasya drinking 3 liters/day and eating 3 apples/day for week
	And His friends drinking 4 liters/day and eating the same munber of apples for week
	Then Vasya will have -33 liters of water and no apples

Scenario: Vasya's friends drinking water and eating apples
	Given Vasya have 100 liters of water
	And Vasya have 27 apples
	And Vasya have 4 friends
	When Vasya's friends drinking 4 liters/day and eating the same munber of apples for week 
	Then Vasya will have -12 liters of water and no apples