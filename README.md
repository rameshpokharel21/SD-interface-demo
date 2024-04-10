## Code:You SD Interface Demo
#### Run the program, then read through the code and comments. If there's something you don't understand post a question in the Slack channel.

Try it yourself! Add a new contact method:
1. Create a new class named `PhoneCaller.cs`
1. Implement the interface with a unique `Console.WriteLine()` template
1. Add a corresponding value to the proper enum (so users can refer to the phone call service)
1. Add the corresponding key:value pair to the proper dictionary (so the `User` constructor can instantiate the new service)
1. Add a new user to the static `List<User>` list in `User.cs` or edit an existing one; be sure to make the new contact method the preference
1. Run the program. Does the new contact service work?

*If you get stuck, message Ryan or post in the Slack channel which step you need help with*

Once completed, notice which classes and logic required no changes (or no substantive changes) to add this new functionality. This is a benefit of OOP, and returns increase with the complexity of a program.