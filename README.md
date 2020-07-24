# Bakery Vendor Tracker

#### Latest version date 2020/07/24

#### By Sean Downs

## Description
This application will track the vendors that purchase baked goods from Francious and the orders belonging to those vendors

## Specifications

1. **Behavior:** The user will be able to add a vendor to the tracker
    * **Input Example:** Click to add vendor
    * **Output Example:** Crestmont Croissant

2. **Behavior:** The user will be able to add orders with title, description, date, and price to the vendor object
    * **Input Example:** Crestmont Croissant Order, 40 croissants, 07/25/2020, 18
    * **Output Example:** Vendor Order

3. **Behavior:** The user will be able to delete orders.
    * **Input Example:** Delete Order
    * **Output Example:** Order Deleted

4. **Behavior:** The user will be able to delete Vendors
    * **Input Example:** Delete Vendor
    * **Output Example:** Vendor Deleted

## Setup and Installation

Software Requirements
1. .NET framework
2. A code editor (Visual Studio Code, Atom, etc.)

Acquire The Repo:
1. Click the 'Clone or Download Button
2. Alternately, Clone via Bash/GitBash: `git clone {repo}`

Editting the Code Base:
1. Open the project in your code editor; with Bash, this is done by navigating to the project directory, then `code .`
2. If you wish to run testing, you'll need the testing packages: navigate into the .Tests folder, and run `dotnet restore`

Running the program:
1. To run the program, you'll need to compile the code: `dotnet build`. This will create a compiled application in the bin/ folder.
2. Alternately, you can run the program directly with `dotnet run`.

## Bugs

Routes aren't connecting in spots

## Tech used

* C#
* ASP.NET Core MVC
* CSHTML
* CSS


### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

Copyright (c) 2020 Sean Downs
