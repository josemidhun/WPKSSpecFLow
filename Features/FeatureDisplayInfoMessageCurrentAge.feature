Feature: FeatureDisplayInfoMessageCurrentAge
In Order to get a clear understanding of what needs to be entered in the field.
As a Product Owner
I want that while using the KiwiSaver Retirement Calculator all fields in the calculator have got the information icon present

@mytag
Scenario: Display message for Current Age Current Age
Given the User Navigates to Westpac KiwiSaver Scheme Retirement Calculator Page
When the User Clicks Information Icon besides Current Age Field
Then the User can See the Message is displayed below Current Age Field