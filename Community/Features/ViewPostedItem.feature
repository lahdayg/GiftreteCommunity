Feature: ViewPostedItem
	As a giftrete web user
   I want to be able to view item posted on the community page
   So that I see if they are anything of my interest

@mytag
Scenario: View Posted item
	Given I navigate to the site
    When  i click  login
    And I enter Email "email address
    And i enter password
    And i click Signin
    And i click on community
	And i click on view communities
	And i click on David Sport
	Then i can see items posted