﻿Feature: Smart3D

Automating the Smart-3D app.

@Smart3D
 Scenario:                                                       Opening the Smart3D App.
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
	And Then validate Bass gain to '4' Middle gain to '-3' Treble gain to '5'
	When I press on Tinnitus Manager on All Around  Sound Enhancer
	And I press Nature sound button Calming Waves on All Around Tinnitus manager
	And I press Nature sound button Breaking Waves on All Around Tinnitus manager
	When I press the exit button on All Around Sound enhancer
	And I swipe left to Hear in Noise program from current program
	And validate program card is Hear in Noise
	When I press Sound Enhancer button on Hear in noise program
    And I press Tinnitus Manager on Hear in noise Sound Enhancer
    And I press white noise button Slight variation on Hear in noise Tinnitus Manager
	When I press Reset button on All-Around Tinnitus Manager
    And I press the exit button on Hear in noise Sound Enhancer
	When I swipe left to Outdoor program from current program
	Then validate program card is Outdoor
	When I press Sound Enhancer button on Outdoor program
    And I drag Wind Noise Reduction to 'Strong' on Outdoor Sound Enhancer
    And validate HI PNR value is 'Strong'
    And I press the exit button on Outdoor Sound Enhancer
    And I swipe left to Music program from current program
    And validate program card is Music
    When I press Music program on the top ribbon bar
    And validate program card is Musicribbon
    When I press Outdoor program on the top ribbon bar
    And validate program card is Outdoorribbon
    When I press Hear in noise program on the top ribbon bar
    And validate program card is Hear in Noiseribbon
    When I press All-Around program on the top ribbon bar
    And validate program card is All-Around
    When I press Program overview button on topribbonbar
    And I press Hear in noise program on Program overview
    When I press Outdoor program on Program overview
    When I press Music program on Program overview
    When I press All-Around program on Program overview
    When I press the Close button on Program overview
    When I press menu item My ReSound on bottom ribbon bar
    And I press Learn about the app on My ReSound	
    And I press Volume control on Learn about the app
    And I swipe left to 2 / 3 page on Learn about the app
    Then validate Left and right volume animation is shown on Volume control
    When I swipe mute left to 3 / 3 page on Learn about the app
    Then validate Mute animation is shown on Volume control
    When I close on Learn about the app and back to My Resound page
    And I press Guiding tips on My ReSound
    And I press OK on Please notice dialog
    Then validate title is Guiding tips on Guiding tips page
    When I press Noise filter on Guiding tips
    And I press Got it on Noise filter nudging dialog
    And I press My Resound on bottom ribbon bar and back to Guiding tips on My Resound
    And I press Music program on Guiding tips
    Then validate Got it button enabled on Music program nudging dialog
    Then validate Back to tips button enabled on Music program nudging dialog
    When I press Got it on Music program nudging dialog
    And I press menu item More on bottom ribbon bar
    Then validate Auto-activate favorite locations switch is on
    When I press Auto-activate favorite locations switch on More menu
    Then validate Auto-activate favorite locations switch is off
    When I press Auto-activate favorite locations switch on Moremenu
    Then validate Autoactivate favorite locations switch is on
    When I press more menu item About
    Then validate page title is displayed on About page
    And validate html view is displayed on About page
    When I press back from About page
    And I press more menu item Legal information
    And I press Legal information item MANUFACTURER
    Then validate page title is displayed on Manufacturer page
    When I press back from Manufacturer page
    And I press Legal information item TERMS AND CONDITIONS
    Then validate page title is displayed on Terms and Conditions page
    When I press back from Terms and Conditions page
    And I press Legal information item PRIVACY POLICY
    Then validate html view is displayed on PRIVACY POLICY page
    And validate page title is displayed on PRIVACY POLICY page
    When I press back from PRIVACY POLICY page
    And I press back from Legal information page
    And I press more menu item Support
    Then validate html view is displayed on Support page
    And validate page title is displayed on Support page
    When I press back from Support page
    Then I press menu item Home on bottom ribbon bar


	


