Feature: Add Note pagee
 As a user
 I want add note
 In order to do important notes

Background:
	When I tap on new user button
	When I done information in registration field
	When I chose first December as a start cycle day
	When I save data
	When  I tap on Add Note button

@addNotePage @addNewNote
Scenario: Create new note	
	When I tap on create Note button
	When I enter 'I had a blood' in a field
	When I save changes on creating Note page
	Then I see my new note 'I had a blood' near create Note button

@addNotePage
Scenario: Change note
	When I tap on create Note button
	When I enter 'Hoorey' in a field instead of previous text
	When I save changes on creating Note page
	Then I see my new note 'Hoorey' near create Note button

@addMood
Scenario: Select mood sticker	
	When I tap on Moods button
	When I select angelic sticker
	When I save changes on mood stickers page
	Then I see chosen sticker near Moods button

@addSymptoms
Scenario: Select symptoms sticker
	When I tap on Symptoms button
	When I select Dizziness sticker
	When I save changes on symptoms stickers page
	Then I see chosen sticker near Symptoms button
#
#@addSymptoms
#Scenario: Add more symptoms sticker	
#	When I tap on Symptoms button
#	When I select Acne and Migraines sticker
#	When I save changes
#	Then I see chosen sticker near Symptoms button


#@addNotePage @addNewNote @addMood @addSymptoms
#Scenario: Create new note	
#	When I tap on create Note button
#	When I enter 'I had a blood' in a field
#	When I save changes on creating Note page
#	When I tap on Moods button
#	When I select angelic sticker
#	When I save changes on mood stickers page
#When I tap on Symptoms button
#	When I select Dizziness sticker
#	When I save changes on symptoms stickers page

