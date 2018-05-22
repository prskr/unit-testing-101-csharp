# Unit testing 101 - Ruby

This is a basic introduction to unit testing in Ruby.
To learn the basics of testing, you will implement the well-known game _Fizz buzz_.

Depending on who you ask you will get different answers according to the rules of this game.
The basic concept is that multiple persons are counting from 1 to n (most probably you won't reach n on a cozy evening with your friends, but that's a different story).
Everyone increments the number of previous player and says either the number, _fizz_, _buzz_ or _fizzbuzz_ depending on some conditions.

For this introduction we will use the following rules:

- respond with _fizz_ if the number is dividable by 3
- respond with _buzz_ if the number is dividable by 5
- respond with _fizzbuzz_ if the number is dividable by 3 **and** 5

## Getting started

### Setup

For this introduction, we will use `unit-test` to run unit tests.
The repository contains a `Gemfile` which already defines the dependency to `unit-test`.
To be able to run the test you need:

- Ruby
- Bundler

To get the required dependencies with Bundler and install them to a local directory execute the following snippet:

```bash
$> bundle install --path bundle/
```

_Note: if you omit the parameter `--path bundle/` Bundler will try to install the libraries in the global gem cache which will most likely require `root` access._

### Running the tests

As soon as the dependencies are installed, you're good to go.
Executing tests in Ruby can be a little bit more cumbersome than it is e.g. in Python.
To avoid frustration, the repository already contains some bootstrap code to get you started as fast (and relaxed) as possible.
Just run **one** of the following two snippets:

```bash
$> ./run_tests.sh
```

```bash
$> bundle exec ruby test/run_test.rb
```

The second script file contains the actual tests that are executed in the first snippet.

_Note: you're **required** to use `bundle` to execute `ruby` because otherwise `ruby` won't find the locally installed libraries!_

## Iteration 1

In the first iteration, you will implement the function `fizz_buzz` so that all given unit tests are running successfully.
Keep in mind that till now everything is allowed:

```rb
class FizzBuzz
    def self.result(num)
        return 'fizz' if num == 3
        "#{num}"
    end
end
```

is an entirely valid solution to run the first unit test successfully.
Unit testing (and especially TDD) aims to find the most straightforward solution available to solve the given problem!

The implementation of the function `fizz_buzz` will evolve while you're fixing all failing test cases.

When all test cases are fixed, you will probably want to add more test cases to cover some edge cases!

## Iteration 2

In the second iteration, we will add some additional rules your implementation should also take care off:

- respond with _fizz_ if the number contains the digit 3
- respond with _buzz_ if the number contains the digit 5
- respond with _fizzbuzz_ if the number contains the digits 3 **and** 5

Start by writing corresponding test cases **first** and then change your implementation to fix the failing test cases.

## Iteration 3

In the third iteration we will create a special edition:

- instead of _fizz_ return _Rick_
- instead of _buzz_ return _Morty_
- instead of _fizzbuzz_ return _RickMorty_

_Note: special credits if you manage to return **Rick and Morty** instead of **RickMorty**._

Start by updating the tests **first** to check for the new terms and then adjust your code to actually do whatever the tests are expecting it to do!

## Iteration 4

In the fourth and last iteration we will change back to _fizz_, _buzz_ and _fizzbuzz_ but:

- return _fizz_ if the number is dividable by **2** or contains the digit **2**
- return _buzz_ if the number is dividable by **7** or contains the digit **7**

_Note: free coffee for the first one who thought of creating commits for each iteration and therefore is able to roll back to the commit before Rick and Morty._

And again, **first** update and extend your test suite and after that start working on the actual implementation.

## Conclusion

Writing the tests first is one of the key principles of Test-Driven Development (TDD).
By writing the tests first, you'll focus on what you expect the code to do and, probably even more import, not to do.
Furthermore by keeping the solution as simple as possible to get the tests <span style="color: green;">"green"</span> you're actively protecting yourself against over-engineering.

You should have noticed that even more significant changes are way more comfortable with a good test suite because you don't have to worry if you forgot an edge case as long as the tests are running, you're on the right way to a reliable solution.