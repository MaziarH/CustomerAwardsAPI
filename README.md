# Customer Awards API
## Data Models
### Data structures
    To do this challenge in a fast and simple way, we pass over the Repository and DTO levels.
    Also, we do not have a SQL Server database, and make data objects in memory on startup.
    We have minimal properties for data entity classes:
    Customer:
        - Id: int (Key)
        - Name: string
    Transaction:
        - CustomerId: int (FoerignKey)
        - Date: DateTime
        - Amount: double
### Seed Data
    To run easier, we have a Seed function to add data into the entity tables.
    The data is a three-months duration (30 transactions) for 5 people.

## Controllers:
### API Transaction
    We required an API to return awards for each people per month and total.
### 1- /api/Transaction
    Return all Customers' Rewards per months
![imagename](/1.jpg)

### 2- /api/Transaction/{id} 
    Return One Customer's Rewards per months, based on Customer Id.
![imagename](/2.jpg)

### 3- /api/Transaction/Total
    Return all Customers' Rewards in Total
![imagename](/3.jpg)

# 

## Unit Test
Test with important amounts:

| Input | Expected |
|-------|----------|
| 50.50 | 0 |
| 50.51 | 1 |
| 100.50 | 50 |
| 100.51 | 51 |

Test passed successfully:

![imagename](/test.jpg)



