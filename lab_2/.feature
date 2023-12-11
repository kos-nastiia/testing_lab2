Feature: Removal of products from the cart for problem_user

Scenario: Problem user removes a product from the cart
    Given The problem_user is logged into saucedemo.com
    And The user adds a product to the cart
    When The user navigates to the cart
    And The user clicks on the REMOVE button for the product
    Then The product should be removed from the cart