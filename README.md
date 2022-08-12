# Fisher Yates Algorithm

## *Fisher-Yates*

I spent a bit longer than I wanted to on this. 
This was because I got a bit carried away - I found the problem very interesting.
Having said that there are bits of my solution I'm not happy with. 
I intend to ramble a bit about that here and discuss the next steps.

# IEnumerable vs IAsyncEnumerable

There not a huge deal to be said here, it took me awhile to convince myself it would be possible to have an IAsyncEnumerable version, but really it should be quite simple.
I've gone with the IEnumerable partly because I've used up the time I was willing to commit and partly to keep things simple.
Without further indication of how we plan to use this routine it's all just guesswork.
The IAsyncEnumerable would be quite valuable if we had massive lists to randomise or the random number generator was a lengthy process. (maybe we're manually entering dice rolls?)
Otherwise we can make do with the IEnumerable.

# IRandomNumberGenerator vs Testing for non-determinism

This is where I wasted most of my time, trying to justify tests for non-determinism! In the end I couldn't.
I'll ramble a bit about why, then talk about what I would do if I ~~wanted~~ needed to implement a random number generator.

The bit I struggled with, and I'm happy to be wrong about this so correct me if I am, is that the Fisher-Yates algorithm has no component in it to generate a random number.
It just uses random numbers to randomise the order of a list.
With this in mind I've just used a inteface to pass in a method of generatoring random numbers.
I would then expect a test suite of non-deteminism tests to be performed against any custom implementation of this interface, not against the fisher yates itself.
(I guess I've trivialised the problem a bit by relying on the Fisher-Yates proof - that the list is randomly ordered, if the random numbers are random and the algorithm is done correctly.)
"The algorithm is done correctly" part I would expect to be tested by passing in non-random IRandomNumberGenerator instances and manually calculating the sequence to validate against.
In the code the test for this is pretty limp and would need more and more varied test data really. (more time)

For the test suite of non-determinism tests I would use a library implementation of the diehard tests to run against my random number generator.
Or there may be a better suite of tests out there to run. 
The important part is realising that random number generating is a non-trivial important and difficult issue of the cryptography field.
To me that means third party libraries or even specialist developers - something implemented with more than a couple hours research anyway.

# Unit Tests

I described one the tests as a bit limp earlier but really its the coverage to.
I tend to like to keep the three E's - Expected, Extreme, and Exception, and we'll I ran out of time before I could consider Extreme and Exception test cases.
Very quickly, 
*	extreme -> empty list?
*	extreme -> massive list? max int?
*	exceptional -> null list
	

# Javadocs (what do we call these for C# - still javadocs?)

Truthfully I've commit a terrible crime throughout with my rubbish/missing javadocs.
For this task these were not my concern. 
For professional development I would expect to produce clear, concise, and helpful javadocs for everything.

# Extras
xUnit (2.4.1) - Unit testing framework.
xUnit.runner.visualstudio (2.4.3) - Helper to run the unit tests and get reports from visual studio.
