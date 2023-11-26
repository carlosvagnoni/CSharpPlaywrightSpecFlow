Feature: 1 Demoblaze Sign Up

  As a new User
  I want to sign up for the website
  so that I can access its features and services.

  Scenario Outline: User signs up successfully
    Given the user is on the Registration Page.
    When the user provides the following registration details: '<username>', '<password>'.
    And the user clicks on the Sign Up button.
    Then the user should be registered successfully.
    Examples:
      | username | password |
      | admincv  | admincv  |