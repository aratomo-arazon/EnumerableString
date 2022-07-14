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
    static Example() { init(); }
    public static readonly string FOO;
    public static readonly string BAR;
    public static readonly string BAZ;
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

## Note
If `<Nullable/>` in the .csproj file is set to true, the following warnings will be issued and you should take action accordingly.
* CS8618
* CS0649

## License
[MIT](./LICENSE)

## Author
[aratomo-arazon](https://github.com/aratomo-arazon)





