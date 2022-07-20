# Customer Awards API
## API Request and Response example:

### 1- All Customers Rewards per Months
### * Request URL

https://localhost:7104/api/Transaction

### * Response Body

```
[
  {
    "id": 1,
    "name": "Maziar Hassanzadeh",
    "month": "Jan.",
    "sumInMonth": 2
  },
  {
    "id": 1,
    "name": "Maziar Hassanzadeh",
    "month": "Feb.",
    "sumInMonth": 10
  },
  {
    "id": 1,
    "name": "Maziar Hassanzadeh",
    "month": "Mar.",
    "sumInMonth": 120
  },
  {
    "id": 2,
    "name": "Sara Moghadam",
    "month": "Jan.",
    "sumInMonth": 90
  },
  {
    "id": 2,
    "name": "Sara Moghadam",
    "month": "Feb.",
    "sumInMonth": 5
  },
  {
    "id": 2,
    "name": "Sara Moghadam",
    "month": "Mar.",
    "sumInMonth": 82
  },
  {
    "id": 3,
    "name": "John Smith",
    "month": "Jan.",
    "sumInMonth": 120
  },
  {
    "id": 3,
    "name": "John Smith",
    "month": "Feb.",
    "sumInMonth": 412
  },
  {
    "id": 3,
    "name": "John Smith",
    "month": "Mar.",
    "sumInMonth": 690
  },
  {
    "id": 4,
    "name": "Parsa Anderson",
    "month": "Jan.",
    "sumInMonth": 0
  },
  {
    "id": 4,
    "name": "Parsa Anderson",
    "month": "Feb.",
    "sumInMonth": 50
  },
  {
    "id": 4,
    "name": "Parsa Anderson",
    "month": "Mar.",
    "sumInMonth": 50
  },
  {
    "id": 5,
    "name": "Nima Grooman",
    "month": "Jan.",
    "sumInMonth": 50
  },
  {
    "id": 5,
    "name": "Nima Grooman",
    "month": "Feb.",
    "sumInMonth": 113
  },
  {
    "id": 5,
    "name": "Nima Grooman",
    "month": "Mar.",
    "sumInMonth": 0
  }
]
```

### 2- One Customer's Rewards per Months (Id = 1)
### * Request URL

https://localhost:7104/api/Transaction/1

### * Response body
```
[
  {
    "id": 1,
    "name": "Maziar Hassanzadeh",
    "month": "Jan.",
    "sumInMonth": 2
  },
  {
    "id": 1,
    "name": "Maziar Hassanzadeh",
    "month": "Feb.",
    "sumInMonth": 10
  },
  {
    "id": 1,
    "name": "Maziar Hassanzadeh",
    "month": "Mar.",
    "sumInMonth": 120
  }
]
```

### 3- All Customers Total Transaction
### * Response Body

https://localhost:7104/api/Transaction/Total

### * Response Body
```
[
  {
    "id": 1,
    "name": "Maziar Hassanzadeh",
    "sumInMonth": 132
  },
  {
    "id": 2,
    "name": "Sara Moghadam",
    "sumInMonth": 177
  },
  {
    "id": 3,
    "name": "John Smith",
    "sumInMonth": 1222
  },
  {
    "id": 4,
    "name": "Parsa Anderson",
    "sumInMonth": 100
  },
  {
    "id": 5,
    "name": "Nima Grooman",
    "sumInMonth": 163
  }
]
```

## Controllers:

### API Transaction
    We required an API to return awards for each people per month and total.
### 1- /api/Transaction
    Return all Customers' Rewards per months
![imagename](/1.jpg)

![alt text](http://url/to/1.jpg)

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

#

## Logging and Exception Handling

### In this sample we have built-in Logger handler and Try-Catch block to isuue log of Information or Error Message.

### In advanced level, we can use Nlog or Log4Net Nuget package and declare Logs Model to figure out, categorize, and save the logs.

# 
### Thank You
### 
### Maziar


