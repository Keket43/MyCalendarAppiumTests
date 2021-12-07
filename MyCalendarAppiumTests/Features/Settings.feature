Feature: Settings
 As a user
 I want to change settings
 In order to customise my calendar

Background:
	When I tap on new user button
	When I done information in registration field
	When I chose first December as a start cycle day
	When I save data

@settingsScreen
Scenario: Open settings module
	When I tap on Settings tab on the main screen
	Then I see Settings screen

@periodLengthScreen
Scenario: Set period length manually
	When I tap on Settings tab on the main screen
	When I tap on Period Length button
	When I tap on Plus icon
	Then Amount of days on screen increments
	When I tap on OK icon
	Then Settings screen opens with new period length

@periodLengthScreen
Scenario: Set average period length
	When I tap on Settings tab on the main screen
	When I tap on Period Length button
	When I tap on Use average toggle
	When I tap on first radio button on popup
	When I tap on OK
	Then Use average toggle is On

@pregnancyMode
Scenario: Turn on Pregnancy mode
	When I tap on Settings tab on the main screen
	When I tap on Pregnancy menu item
	When I tap on "I\'m pregnant!" toggle
	When I tap on Continue
	When I tap on back arrow icon
	Then Pregnancy toggle is ON

@pregnancyMode
Scenario: Turn off pregnancy mode
	When I tap on Settings tab on the main screen
	When I tap on Pregnancy menu item
	When I tap on I\'m pregnant toggle
	When I tap on Continue
	When I tap on Turned on by mistake option
	When I tap TURN OFF on popup
	Then I\'m pregnant toggle is off