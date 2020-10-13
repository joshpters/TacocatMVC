# Tacocat Challenge Minisite in MVC

This is a minisite that based on my [original](https://github.com/joshpters/TacocaT) Tacocat challenge minisite, this time build using .NET Core and MVC.

![Screenshot](TacocatMVC/screenshot.PNG)

This project was created using .NET Core, C#, Bootstrap, HTML5, CSS3, and JavaScript.

## What is the "Tacocat" challenge?

The word "Tacocat" is a palindrome, meaning it's spelled the same forwards and backwards.
This challenge is about building a function to detect these.

Traditionally knows as the "reverse a string" exercise, it has in some form
been used by technology companies such as Amazon, Microsoft, VMware and Norton
to assess a candidate’s ability to code an impromptu algorithm.

## Installation

This site is currently not live yet.

However, to download and run locally, clone this repository.

``` sourceCode
git clone https://github.com/joshpters/TacocatMVC
```

## Core Function

This is a basic form of the function that reverses the string, returns it to the output, and determines if it is a palindrome.

Currently all data is sent by an HTTP Post request to the server and processed in C#, then the page is regenerated and sent back with the output.

```c#
[HttpPost]
public IActionResult Solve(string input1, string input2)
{
	var fizzNum = Convert.ToInt32(input1);
	var buzzNum = Convert.ToInt32(input2);

	var output = new StringBuilder();

	if (fizzNum == 0 || buzzNum == 0)
	{
		return View();
	}

	for (var index = 1; index <= 100; index++)
	{
		if (index % fizzNum == 0 && index % buzzNum == 0)
		{
			output.AppendLine("FizzBuzz");
		}
		else if (index % fizzNum == 0)
		{
			output.AppendLine("Fizz");
		}
		else if (index % buzzNum == 0)
		{
			output.AppendLine("Buzz");
		}
		else
		{
			output.AppendLine(index.ToString());
		}
	}

	ViewData["Output"] = output;

	return View();
}
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.
 
