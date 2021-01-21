Feature:  trigonometrische Funktionen
	
	Als Mathematiklehrer
	möchte ich eine Taxhenrechner der  trigonometrische Funktionen berechnen kann.

@mytag
Scenario: sinus
	Given the number is 3.1415
	When I chose sinus
	Then the result should be 0

	Scenario: cosinus
	Given the number is 3.1415
	When I chose cosinus
	Then the result should be -1


	Scenario: tangens
	Given the number is 3.1415
	When I chose tangens
	Then the result should be 0