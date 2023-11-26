Feature: 3 Add Product to Cart

  As a Logged-in User
  I want to add a product to my shopping cart
  So that I can proceed to checkout and make a purchase

  Background:
    Given the user has signed up with credentials: 'admincv', 'admincv'.
    And the user is on the Login Page.
    When the user inputs their username and password into the form.
    And the user clicks on the Submit button.
    Then the user should be logged in.

  Scenario: User adds a laptop product to the cart
    Given the user is browsing the list of available products.
    When the user selects a product from the laptops category.
    And the user adds the selected product to the shopping cart.
    Then the product should be added to the user's shopping cart.