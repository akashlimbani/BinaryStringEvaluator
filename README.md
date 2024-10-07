# Binary String Analysis

This project provides a function to evaluate binary strings based on specific criteria, determining whether they are classified as 'good'. A binary string is considered 'good' if it satisfies the following conditions:

1. It contains an equal number of '0's and '1's.
2. For every prefix of the string, the number of '1's is not less than the number of '0's.

## Table of Contents

- [Requirements](#requirements)
- [Functionality](#functionality)
- [Example](#example)

## Requirements

- .NET Core SDK (version 3.1 or higher)

## Functionality

The core functionality is implemented in the `Function` class, which contains the following method:

### `IsGoodBinaryString(string binaryString)`

- **Parameters**: 
  - `binaryString`: A string containing only '0's and '1's.
  
- **Returns**: 
  - `bool`: Returns `true` if the string is 'good'; otherwise, returns `false`.

### Example

```csharp
bool result = Function.IsGoodBinaryString("1100"); // returns true
