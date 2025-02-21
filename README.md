# NullReferenceException in C# Property Access

This repository demonstrates a common C# error: a `NullReferenceException` that occurs when accessing a class property that has not been assigned a value.  The `bug.cs` file contains the problematic code, while `bugSolution.cs` shows the corrected version.

## Problem

In the `MyClass` class, the `MyMethod` attempts to perform a calculation using the `MyProperty` without checking if it has been initialized.  If `MyProperty` remains its default value of `null` (for reference types) or 0 (for value types), this will result in a `NullReferenceException`. 

## Solution

The solution involves initializing `MyProperty` to a default value in the class constructor or before using it in `MyMethod`.  Alternatively, you can add a null check to handle cases where the property might not have been set.