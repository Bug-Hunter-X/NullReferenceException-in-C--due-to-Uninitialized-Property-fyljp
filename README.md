# NullReferenceException in C# due to Uninitialized Property

This repository demonstrates a common error in C#: accessing a property before it has been assigned a value.  This often leads to a `NullReferenceException`.

The `bug.cs` file shows the erroneous code, while `bugSolution.cs` provides the corrected version.

## How to reproduce

1. Clone this repository.
2. Compile and run `bug.cs`. You'll encounter a `NullReferenceException`.
3. Modify the code to match the solution in `bugSolution.cs`. Run the code again; it should now execute without errors.

## Understanding the issue

In C#, properties and fields are not automatically initialized to default values when an object is created. If you attempt to use a property or field before it's been set, you'll trigger a `NullReferenceException`.

## Solution

Always initialize properties and fields either in the constructor or when you first access them.  Make sure to provide meaningful default values.