Feature: 2 Demoblaze Login
  As a User
  I want to log in to the website
  so that I can select and check out a destination.

  Scenario Outline: User logs in successfully
    Given the user has signed up with credentials: '<username>', '<password>'.
    And the user is on the Login Page.
    When the user inputs their username and password into the form.
    And the user clicks on the Submit button.
    Then the user should be logged in.

    Examples: 
      | username | password |
      | admincv  | admincv  |
