Feature: Main page
 As a user
 I want to main page
 in order to i can use main function in program

Background:
	When I click on new user button
	When I done information in registration field
	When I chose first December as a start cycle day
	When i save data

@logPage @addPeriod
Scenario: Add previous cycle in period
When I click on log button
When I click on add period button
When I chose first november in period
When I save changes
When I click on back button in log page
When I click on calendar button
When I click on previos button
Then I see remove november period

@setting @changeLanguage
Scenario: Change language from English to Russian
When I click on setting button
When I click on language button
When i click on Russian language
Then I see a 'Календарь' button


@chart @changeCharacters
Scenario: Change weight and hight
When I click on chart button
When I click on add button
When i click on change weight '58'
When i click on change height '165'
When i click on change save
Then I see a '58' weight in field