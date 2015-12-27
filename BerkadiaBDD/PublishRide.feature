Feature: Publish Ride
As A Berkadia employee I want to publish ride so other employee can travel with me

Scenario: Data must be valid
Given Employee enter all data correctly
When click on "Submit" button
Then System should display a message "Posting was successful."

Scenario: Empployee name is required
Given Employee enter name as "Naveen Singh", Phone is "9810547500" email as "naveen.singh@leanpitch.com" origin is "Hitech City" destination is "Miyapur" and time is "5:30 pm"
When click on "Submit" button
Then System should display a message "Posting was successful."

Scenario: Empployee name cannot be blank
Given Employee enter name as "", Phone is "9810547500" email as "naveen.singh@leanpitch.com" origin is "Hitech City" destination is "Miyapur" and time is "5:30 pm"
When click on "Submit" button
Then System should display a message "Name can't be blank"



