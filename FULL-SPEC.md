# *Fisher-Yates*

This task focuses on code design and unit-testing for a non-deterministic algorithm.

The *FisherYates* folder contains a bare-bones [ASP.NET Core 5.0](https://docs.microsoft.com/en-us/aspnet/core/getting-started/?view=aspnetcore-5.0&tabs=windows) solution with a "Web app" project and a supporting "Unit test" project. 

The [*Fisher-Yates shuffle*](https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle) is a classic and simple algorithm for shuffling an input sequence of elements. The  [modern version of the algorithm](https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle#The_modern_algorithm) (either direction) is the focus of this task.

The provided app has a single endpoint for this algorithm, `GET /fisheryates`, defined as follows:

* **Input:** A string, containing the dasherized list of elements to shuffle (e.g. "D-B-A-C").
* **Response:** A `200 OK` HTTP response with a content-type of `text/plain; charset=utf-8`. The content should be the dasherized output of the algorithm, e.g. "C-D-A-B".

### Your task

In the web application project, add code structures that would support the implementation of the modern version of the algorithm linked above. The code structures should be in **skeleton form only** for holding the algorithm's logic. All method bodies should simply throw a new `NotImplementedException`. 

Then, implement **unit tests only** to test the algorithm.

**Do:**
* Structure the skeleton for the solution in the web app project in a way that you feel follows best-practices for a modern Asp.Net Core 5.0 web application.
* Write unit tests for correctness, to the extent that you feel is appropriate and follows best-practices. The testing approach should address the issue of non-determinism ("randomness").
* Feel free to use any libraries (e.g. from NuGet) if you feel they'd help you.

**Do not:**
* Do **not** actually implement the algorithm. **You only need to build the skeleton structure and write the unit tests**. All your unit tests should be failing in your submission (a la [TDD](https://en.wikipedia.org/wiki/Test-driven_development) and its red-green development cycle).
* Do **not** worry about server-side validation (assume the inputs are always valid).
* Do **not** implement any kind of end-to-end/acceptance/Selenium/browser testing (i.e. just write the unit tests).
* Do **not** implement any kind of performance testing or similar (i.e. just focus on unit testing for correctness).

Overall:
* Use **additional libraries and reference material** as you wish.
* Unless explicitly discouraged, feel free to optimize your submission in any way you feel is important.
* In the interest of fairness, please **refrain from asking us questions**. If you do find yourself unsure about something, use your common sense to make an assumption, and clearly state it in an obvious place in your submission (e.g. a README file).