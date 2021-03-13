# Enumeration types (Enums)

An enum is a set of constant names that are assigned a numeric value.
If a number is not assigned, it starts at 0 by default and increments by one.

For example, the following enums are identical:

```csharp
enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}
```

```csharp
enum Season
{
    Spring = 0,
    Summer = 1,
    Autumn = 2,
    Winter = 3
}
```

> Note: By default the numeric type is an integer

In order to give a specific value, we do as follows:

```csharp
enum SeasonCodes
{
    Spring = 100,
    Summer = 15,
    Autumn, // this will be 16
    Winter = 200
}
```

Assigning an enum to a variable:

```csharp
Season seasonSpring = Season.Spring;
```

Get the enum as a string:

```csharp
string autumn = Season.Autumn.ToString();
Console.WriteLine(autumn);
// or
Console.WriteLine(seasonSpring);
Console.WriteLine(Season.Summer);

```

> The following will NOT work: `string summer = Season.Summer;`

Get the enum as an integer:

```csharp
int summerCode = (int)Season.Summer; // 1
```

Get an integer as an enum:

```csharp
int winterCode = 3;
Season seasonWinter = (Season)winterCode; //or (Season)3
```

## Resources

[Enumeration types - Microsoft docs](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)
