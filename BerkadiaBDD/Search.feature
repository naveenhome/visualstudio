Feature: Search

Scenario: Search by Valid Destination
Given user enter Destination as "Hitech City"
When click on "Search"
Then Display all matching rides

Scenario: Search by InValid Destination
Given user enter Destination as "Hitech City"
When click on "Search"
Then System display "There is no matching ride available"

Scenario: Search by InValid Destination and Origin
Given user enter Destination as "Hitech City" and origin is "Miyapur"
When click on "Search"
Then System display "There is no matching ride available"

Scenario: UI testing for Destination and Origin
Given User enter "www.carpool.com" in chrome browser
And Move to Search Page
And user enter Destination as "Hitech City" and origin is "Miyapur"
When click on "Search"
Then System display "There is no matching ride available"

Scenario: Search Berkadia
Given User Open "www.google.co.in" in Chrome
And enter "Beekadia India" in Search box
When click on "Search"
Then Result should be more tha 2700

Scenario Outline: Regression Test
Given user enter <source> and enter <destination>
When click on <button>
Then System display <result>

Examples: 
| source | destination | button   | result       |
| "Abc"  | "xyz"       | "Submit" | "successful" |





