Feature: Adminaddanother
	As a giftrete web user
   I want administrator to be able to add other members of the community as an administrator
   So that they can all work together in making the community work well


@mytag
Scenario: Admin add another member as an admin
	Given I navigate to the site
    When  i click  login
    And I enter Email "email address
    And i enter password
    And i click Signin
    And i click on community
	And i click on view communities
	And i click on BJ CHARITY
	And i click on members
	And i click on drop down
	And i click on makeadmin
	Then i am able to assign another member as administartor