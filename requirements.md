# Web API Final Project

**Final submission date:** 12th of Tevet

## Project Overview
Create a web store management system (for games, furniture, vehicles, etc.)
This phase focuses on creating the server side of the site, including:
- Categories
- Products
- Users (Admin/Customer interfaces - to be implemented later)
- Orders

The server will be developed using Web API with Clean Architecture using Code First approach.

## Phase 1: Categories
### Setup
1. Create projects for each layer
2. Prepare data layer for database connection

### Category Table Structure
- CategoryId
- CategoryName

### Required Functions
- GetAll: Retrieve list of categories
- GetByName: Get category by name
- GetById: Get category by ID
- AddCategory: Add new category
- UpdateCategory: Edit existing category
- DeleteCategory: Delete category (development only)

## Phase 2: Products
### Product Table Structure
- ProductId
- ProductName
- CategoryId (Foreign Key)
- Description
- Price
- InventoryQuantity
- ImageSource
- Additional fields as needed

### Required Functions
- GetAll: Retrieve all products
- GetById: Get product by ID
- GetByCategoryId: Get products by category
- GetOutOfStock: Get products with zero inventory
- AddProduct: Add new product
- DeleteProduct: Remove product
- UpdateProduct: Edit product

## Phase 3: Users
### User Table Structure
- UserId
- Username
- Password (not always stored in DB)
- FirstName
- LastName
- Phone
- Address
- Email

### Required Functions
- GetAll: Retrieve all users
- GetByCredentials: Get user by username and password
- GetById: Get user by ID
- AddUser: Create new user
- UpdateUser: Edit user
- DeleteUser: Remove user

## Phase 4: Orders
### Order Table Structure
- OrderId
- OrderDate
- UserId (Foreign Key)
- TotalAmount

### Required Functions
- GetAll: Retrieve all orders (admin interface)
- GetById: Get order by ID
- GetByUserId: Get orders by user (customer interface)
- Bonus: GetByDate: Get orders by date

## Technical Requirements
### Controller Layer
- All dependencies must be injected in Program.cs
- Proper use of controller overloading and parameter passing
- Implement at least 4 status responses (2 error types, 2 success types)

### General Notes
- Test all functions before Angular integration
- Use proper project and folder naming conventions
- Maintain organized file structure
- Use logical and correct naming for files and variables
- Regular project backups
- Reference course materials for implementation details

## Part 2: Advanced Features
**Final submission date:** 26th of Tevet

### 1. Configuration Management
- Move connection string to external file using secret manager

### 2. Unit Testing
Create a separate class library project with 3 test functions:
- Test if all products have more than 3 items in inventory
- Test if user exists (by ID)
- Add one additional test of your choice

### 3. Asynchronous Programming
- Convert one function of your choice to be asynchronous across all layers

### 4. JWT Identity Management
- Add login function for user authentication
- Generate token for admin
- Implement admin-only restrictions for:
  - Adding, editing, and deleting categories
  - Retrieving products with zero inventory
  - Adding, editing, and deleting products
  - Retrieving all orders
- Challenge: Add authorization management for regular users

### 5. Middleware
Create a separate middleware function that:
- Validates if request is POST method
- Checks if category ID is valid for product addition
- Proceeds with request if valid
- Returns error if invalid

### 6. Code Documentation
- Document all code appropriately
