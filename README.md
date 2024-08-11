FastMeals-ASP.NET-Project-004

# FastMeals

## Introduction

FastMeals is application for buying food delivery.

## Features

- Stripe Payment and Refunds
- DataTables API
- MailKit Emails
- Facebook login
- Roles
- SweetAlerts
- Toastr

### User Roles

- **ManagerRole**: The admin of the system - it can access everything
- **FrontDeskRole**: The front deck role - can access Order List,Complete Order,Cancel Order,Refund Order buttons
- **KitchenRole**: The kitchen role - can access Manage Order button
- **CustomerRole**: The customer role - it can only order

## Seeded Roles logins:

- Admin: `username: admin@gmail.com`, `password: Admin123*`

## How to use?

- 0.Download the repository and extract it to folder
- 1.Open FastMeals.sln with visual studio 2022
- 2.In appsetting.json add your personal "ConnectionStrings"
- 3.right click on FastMealsWeb Project and "Set as Startup Project"
- 4.In "Package Manager Console" with Default project: "FastMeals.DataAccess" type: update database
- 5.Ctrl+F5
- 6.Open Url localhost on your browser: https://localhost:5001/
- 7.Enjoy!

## Used libraries:

    - `Tiny` - for advanced description editor
    - `DataTables` - for advanced tables with pagination,search,sorting ect.
    - `SweetAlerts` - for for cool delete notifications
    - `Toastr` - for notifications
    - `jQuery` - simplifying html and css
    - `bootstrap` - CSS Framework
    - `Stripe` - for Payments

## Database

SSMS and MS SQL are used for storing & managing the data.

## Demo

Live demo at Youtube - https://youtu.be/69vzte03_S4

## Photos

Stripe Payment:

![image](/FastMeals/wwwroot/images/githubImages/Stripe%20Payment.png)

Home 1:

![image](/FastMeals/wwwroot/images/githubImages/Home1.png)

Home 2:

![image](/FastMeals/wwwroot/images/githubImages/Home2.png)

Admin panel - CategoryList:

![image](/FastMeals/wwwroot/images/githubImages/Admin%20panel%20-%20CategoryList.png)

Admin Panel - Foodtype list:

![image](/FastMeals/wwwroot/images/githubImages/Admin%20Panel%20-%20Foodtype%20list.png)

Admin Panel - Menu Item List:

![image](/FastMeals/wwwroot/images/githubImages/Admin%20Panel%20-%20Menu%20Item%20List.png)

Admin Panel - Register User:

![image](/FastMeals/wwwroot/images/githubImages/Admin%20Panel%20-%20Register%20User.png)

Manage Orders - Kitchen User:

![image](/FastMeals/wwwroot/images/githubImages/Manage%20Orders%20-%20Kitchen%20User.png)

Menu Item Details:

![image](/FastMeals/wwwroot/images/githubImages/Menu%20Item%20Details.png)

Order List - Front User:

![image](/FastMeals/wwwroot/images/githubImages/Order%20List%20-%20Front%20User.png)

Order List Details - Front User:

![image](/FastMeals/wwwroot/images/githubImages/Order%20List%20Details%20-%20Front%20User.png)

Shopping Cart:

![image](/FastMeals/wwwroot/images/githubImages/Shopping%20Cart.png)

Order successful message:

![image](/FastMeals/wwwroot/images/githubImages/Order%20successful%20message.png)

Order Summary:

![image](/FastMeals/wwwroot/images/githubImages/Order%20Summary.png)

Profile:

![image](/FastMeals/wwwroot/images/githubImages/Profile.png)

Register:

![image](/FastMeals/wwwroot/images/githubImages)

Login:

![image](/FastMeals/wwwroot/images/githubImages)
