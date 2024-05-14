# Elite Estates

Elite Estates is a cutting-edge online platform designed to streamline the process of buying and selling properties, such as flats and lands. This project provides a user-friendly interface that facilitates secure transactions, robust communication between buyers and sellers, and comprehensive management tools for admins.

## Features

Comprehensive User Roles:** The platform has three distinct user roles - Admin, Buyer, and Seller, each with unique functionalities and permissions.
Secure User Registration and Authentication:** Users go through a thorough registration process to ensure the integrity of the platform.
Exclusive Offers and Coupons:** The Admin can introduce exclusive offers and coupons to enhance the user experience.
Listing and Managing Properties:** Sellers can create detailed listings for their properties, including specifications, images, and pricing. They have the ability to manage their listings, update information, and delete listings as needed.
Property Search and Filtering:** Buyers can browse through available properties and apply filters based on their preferences, such as location, property type, and budget.
Secure Communication:** The platform facilitates secure communication between buyers and sellers, enabling negotiation, virtual tours, and discussion of property details.
Payment Integration:** Buyers can add funds to their accounts using various payment methods like Bkash and Nagad, ensuring seamless transactions.
Commission Management:** The Admin collects a 10% commission from the total transaction value upon a successful sale.
Complaint Handling:** The Admin oversees the handling of complaints from buyers or sellers and can restrict users if complaint levels cross a certain threshold.
Post-Transaction Support:** Sellers can withdraw their sale proceeds through the platform's supported payment gateways.

## Technologies Used

- C#
- .NET Framework
- SQL Server
- Windows Forms
 User Stories

### Admin Functions
Log in:** Admins can log into the system using their credentials.
Profile Management:** View and update profile information.
User Management:** Add, remove, and manage user roles.
Password Modification:** Update admin passwords.
Inventory and Transactions:** View current inventory and transaction records.

### Seller Functions
Log in:** Sellers access the system with their credentials.
Manage Listings:** Add, update, and delete property listings.
View Transactions:** View transaction records.
Profile Management:** Update profile information.

### Buyer Functions
 Log in:** Buyers log into the system using their credentials.
 Password Update:** Update passwords.
 Browse Listings:** View available properties.
 Profile Management:** Update profile information.
 Log out:** Safely log out of the system.

  Database Schema
The project utilizes a relational database with the following tables:
- `Admin`
- `AdminBalance`
- `Buyer`
- `BuyerBalance`
- `Complain`
- `Product`
- `Seller`
- `SellerBalance`
- `TransactionHistory`

  Conclusion
Elite Estates provides a robust platform for real estate transactions, ensuring a seamless experience for all users through its comprehensive features and secure processes.


Creating a README.md file for your Elite Estates project on GitHub involves summarizing the project's purpose, features, installation steps, usage instructions, and other relevant information. Here is a draft README.md based on the provided project report:

markdown
Copy code
# Elite Estates

Elite Estates is a cutting-edge online platform designed to streamline the process of buying and selling properties, such as flats and lands. This project provides a user-friendly interface that facilitates secure transactions, robust communication between buyers and sellers, and comprehensive management tools for admins.

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [User Stories](#user-stories)
  - [Admin Functions](#admin-functions)
  - [Seller Functions](#seller-functions)
  - [Buyer Functions](#buyer-functions)
- [Database Schema](#database-schema)
- [Installation](#installation)
- [Usage](#usage)
- [Screenshots](#screenshots)
- [Conclusion](#conclusion)
- [Contributors](#contributors)

## Introduction
Elite Estates is a platform that connects buyers and sellers of real estate properties. Sellers can create detailed listings, and buyers can browse these listings and communicate with sellers through secure messaging. The platform supports various payment methods for transactions and charges a commission fee for successful sales.

## Features
- **User Roles:** Separate functionalities for Admin, Buyer, and Seller.
- **Secure Transactions:** Facilitates secure communication and transactions between buyers and sellers.
- **User Management:** Admins can manage users and handle complaints.
- **Listing Management:** Sellers can create, update, and delete property listings.
- **Search and Filter:** Buyers can search and filter listings based on their preferences.
- **Payment Integration:** Supports various payment methods for adding funds and making transactions.

## User Stories

### Admin Functions
- **Log in:** Admins can log into the system using their credentials.
- **Profile Management:** View and update profile information.
- **User Management:** Add, remove, and manage user roles.
- **Password Modification:** Update admin passwords.
- **Inventory and Transactions:** View current inventory and transaction records.

### Seller Functions
- **Log in:** Sellers access the system with their credentials.
- **Manage Listings:** Add, update, and delete property listings.
- **View Transactions:** View transaction records.
- **Profile Management:** Update profile information.

### Buyer Functions
- **Log in:** Buyers log into the system using their credentials.
- **Password Update:** Update passwords.
- **Browse Listings:** View available properties.
- **Cart Management:** Add items to cart, update cart, and confirm purchases.
- **Profile Management:** Update profile information.
- **Log out:** Safely log out of the system.

## Database Schema
The project utilizes a relational database with the following tables:
- `Admin`
- `AdminBalance`
- `Buyer`
- `BuyerBalance`
- `Complain`
- `Product`
- `Seller`
- `SellerBalance`
- `TransactionHistory`

## Installation
To run this project locally, follow these steps:
1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/elite-estates.git
Navigate to the project directory:
bash
Copy code
cd elite-estates
Install dependencies:
bash
Copy code
npm install
Set up the database:
Create the database using the provided SQL scripts.
Start the application:
bash
Copy code
npm start
Usage
After installing and starting the application, you can:

Register as a Buyer, Seller, or Admin.
Log in with your credentials.
Sellers can create and manage property listings.
Buyers can browse, filter listings, and make purchases.
Admins can manage users and oversee transactions.





Conclusion
Elite Estates provides a robust platform for real estate transactions, ensuring a seamless experience for all users through its comprehensive features and secure processes.

Contributors
Md. Sazzad Hossain - ID: 22-47354-2
Mahiya Akther - ID: 22-47359-2
Mushfiqur Rahman Fahim - ID: 22-47450-2
Md. Asif Uddin - ID: 22-46359-1
