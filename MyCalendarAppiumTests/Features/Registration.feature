﻿Feature: Registration
As a user 
I want to registration page
In order to i can registration in program and use it

@registration
Scenario: Registration new user
	When I tap on new user button
	When I done information in registration field
	When I chose first December as a start cycle day
	When I save data
	Then I see calendar button 'Calendar'
	
	@registration @invalid
Scenario: Invalid Registration new user
	When I tap on new user button
	When I clear on period field button
	When I clear on cycle field button	
	Then I cant went go over page and i see toast message