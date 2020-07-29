# Sphinx
  
a too simple c# package to make http requests in one line ;)
<br>
<a href="https://www.nuget.org/packages/Sphinx/1.0.0" rel="Nuget">![Nuget](https://badgen.net/nuget/v/Sphinx/latest)</a>

# How to use ?
here some examples 

- Get Request Example:
```cs
  string result = Request.Get("https://github.com/").Body;
  Console.WriteLine(result);
```
- Post Request (JSON) Example:
```cs
  WebHeaderCollection collection = new WebHeaderCollection
  {
      { "authorization", "authorization token" }
  };
  string result = Request.Post("https://github.com/", Converter.JSON(new { content: "hello Sphinx :)" }), ContentType.json, collection).Body;
  Console.WriteLine(result);
```

# how to install ? 
[Nuget](https://www.nuget.org/packages/Sphinx/1.0.0)
