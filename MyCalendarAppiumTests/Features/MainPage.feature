Feature: Main page
 As a user
 I want to main page
 In order to i can use main function in program

Background:
	When I tap on new user button
	When I done information in registration field
	When I chose first December as a start cycle day
	When I save data

@logPage @addPeriod
Scenario: Add previous cycle in period
When I tap on log button
When I tap on add period button
When I chose first november in period
When I save changes
When I tap on back button in log page
When I tap on calendar button
When I tap on previos button
Then I see remove november period

@setting @changeLanguage
Scenario: Change language from English to Russian
When I tap on setting button
When I tap on language button
When I tap on Russian language
Then I see a 'Календарь' button


@chart @changeCharacters
Scenario: Change weight and hight
When I tap on chart button
When I tap on add button
When I tap on change weight '58'
When I tap on change height '165'
When I tap on change save
Then I see a '58' weight in field