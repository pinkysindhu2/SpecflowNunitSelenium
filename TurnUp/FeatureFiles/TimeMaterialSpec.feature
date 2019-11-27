Feature: TimeMaterial
    In order to manage Time and material records
    As an TurnUp portal admin
    would like to create, read, update, and delete TM records

Background: Pre-conditions
    Given I have logged into TurnUp portal
    And I have navigated to Time and Material page


@web @automate
Scenario: Create Time and Material with valid inputs
    When I have clicked on the create new button
    Then I should be able to create a TM record successfully

Scenario: Verify new TM into table
    Given A table with TM records at Time and Material Page
    When Click on the next button on the bottom of the table
    Then New TM record is listed into the table

Scenario: Edit Time and Material with valid inputs
    When I have clicked on the Edit button
    Then I should be able to edit a TM record successfully

Scenario: Delete Time and Material
    When I have clicked on the Delete button 
    Then I should be able to delete a TM record successfully       