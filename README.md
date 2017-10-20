## Description
This is an exercise for learning on applying Design Patterns from the GoF book.
The C# solution contains 2 projects: 
- DesignPatternExercise contains poorly written code, without the use of design patterns
- DesignPatternExerciseTests contains tests for the expected functionality of the code in DesignPatternExercise.

Examples have been kept at a minimum but meaningful, just to illustrate how design patterns can be applied in real world projects. (No abstract Car / Pet nonsense)

## Setup
- Install NUnit Visual Studio Extension
- Build project
- Run tests in DesignPatternExerciseTests -> All should be passing

## Task
Go through each test class and refactor the code inside the subject that is being tested to apply the expected pattern. 
Restriction is to NOT modify anything the DesignPatternExerciseTests project. 
You can modify anything (almost - method signatures / class names cannot change because they will affect the test project) in the DesignPatternExercise project.

## Workflow
Fork the project 
Create a branch (name ex: "refactor")
Refactor 1 example
Make sure the test still pass after the refactor
Commit
Push branch
Open a Pull Request
Continue with the rest of the examples
Changes will be code reviewed on the Pull Request