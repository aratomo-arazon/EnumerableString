# EnumerableString
`EnumerableString` is a utility class for defining constant strings.

## Feature
Field names can be used as values, so there is no need to define values.

## Usage
1. Create a class that extends `EnumerableString<T>` class. T is the class to be created.
2. Add a static constructor to class T that calls `init()`.
3. Add some fields with the same names as the string values you want to define as constants.
```cs
public class Example : EnumerableString<Example>
{
#pragma warning disable CS8618
    static Example() { init(); }
#pragma warning restore CS8618
#pragma warning disable CS0649
    public static readonly string FOO;
    public static readonly string BAR;
    public static readonly string BAZ;
#pragma warning restore CS0649
}
```

4. Each static field you declared provides its own string value.
```cs
Console.WriteLine(Example.FOO);    // FOO
Console.WriteLine(Example.BAR);    // BAR
Console.WriteLine(Example.BAZ);    // BAZ
```

5. An instance of the class provides all string values.
```cs
foreach (var value in new Example())
{
    Console.WriteLine(value);      // FOO -> BAR -> BAZ
}
```

## License
[MIT](./LICENSE)

## Author
[aratomo-arazon](https://github.com/aratomo-arazon)





