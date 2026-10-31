# Using Decision Making in C#

# C# Decision Making Examples

This chapter demonstrates how to use **Decision Making Statements** in C#. These statements allow a program to make decisions based on specific conditions.

## Code Explanation

### 1. If Statement

This example demonstrates how to use an `if` statement to check a condition.

```csharp
int marks = 70;

if (marks > 50)
{
    MessageBox.Show("Pass");
}
```

### 2. If-Else Statement

This example demonstrates how to use `if-else` to execute different actions depending on whether a condition is true or false.

```csharp
int marks = 40;

if (marks > 50)
{
    MessageBox.Show("Pass");
}
else
{
    MessageBox.Show("Fail");
}
```

### 3. Nested If Statement

This example demonstrates how to use an `if` statement inside another `if` statement.

```csharp
int age = 20;

if (age >= 18)
{
    if (age >= 21)
    {
        MessageBox.Show("Adult");
    }
    else
    {
        MessageBox.Show("Age is between 18 and 20");
    }
}
```

### 4. If-Else If Statement

This example demonstrates how to check multiple conditions using `if`, `else if`, and `else`.

```csharp
int marks = 85;

if (marks >= 80)
{
    MessageBox.Show("Grade A");
}
else if (marks >= 70)
{
    MessageBox.Show("Grade B");
}
else if (marks >= 60)
{
    MessageBox.Show("Grade C");
}
else
{
    MessageBox.Show("Fail");
}
```

### 5. Logical Operators

This example demonstrates how to use the `&&` (AND) operator to check two conditions.

```csharp
int marks = 75;

if (marks >= 50 && marks <= 100)
{
    MessageBox.Show("Valid Pass Mark");
}
else
{
    MessageBox.Show("Invalid Mark");
}
```

### 6. TryParse – Input Validation

This example demonstrates how to use `int.TryParse()` to check whether the user's input is a valid integer.

```csharp
int marks;

if (int.TryParse(txtMarks.Text, out marks))
{
    if (marks >= 50)
    {
        MessageBox.Show("Pass");
    }
    else
    {
        MessageBox.Show("Fail");
    }
}
else
{
    MessageBox.Show("Please enter a valid number");
}
```

### 7. Switch Statement

This example demonstrates how to use a `switch` statement to select an action based on a value.

```csharp
int day = 2;

switch (day)
{
    case 1:
        MessageBox.Show("Monday");
        break;

    case 2:
        MessageBox.Show("Tuesday");
        break;

    case 3:
        MessageBox.Show("Wednesday");
        break;

    default:
        MessageBox.Show("Invalid Day");
        break;
}

