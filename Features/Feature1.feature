Feature: Smart3D

Automating the Smart-3D app.

@Smart3D
Scenario: Opening the Smart3D App.
	Given open the app.
	When click on the take me to demo app
	And  opens the app displays the popup button and click on the button.
    When HI program in All-Around
	And display the Right HI and Left HI volumes
	And validate the Right HI and Left HI values is "9" 
	And set surrounding volume is "3" on Right HI and  "10" on Left HI
	And validate the surrounding volume is "3" on Right HI and "10" on Left HI
	When merge surroundings volume on All-Around program
	#And validate HI volume is '3'
	And validate merged surroundings volume is "3" on All-Around program
	And validate HI merged surrounding volume is "13" on All-Around program
    And press speech clarity button on All Around program and validate speech clarity button is enabled
	When press on Noise filter button on All Around program
    And validate Noise filter button is enabled and speech clarity button is disabled.
	When press on speech clarity button on All Around program
	And validate speech clarity button is enabled and Noise filter button is disabled.
	When press on Sound Enhancer button on All Around program
	And set Bass gain to '4' Middle gain to '-3' Treble gain to '5'
	Then validate Bass gain to '4' Middle gain to '-3' Treble gain to '5'


	


