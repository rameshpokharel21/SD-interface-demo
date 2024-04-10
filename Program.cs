﻿// Heads up for M2 Week 1, LINQ written with method syntax:
var hobbits = User.users
                .Where(u => u.Location == Location.TheShire)
                .ToList();

foreach (var hobbit in hobbits) 
{
    hobbit.Contact("Big sale on salted pork and po-ta-toes this weekend!");
}

// Heads up for M2 Week 1, LINQ written with query syntax:
var theFellowship = from user in User.users
                     where user.IsFellowshipMember == true
                     orderby user.Name
                     select user;

foreach (var companion in theFellowship)
{
    companion.Contact("Nine companions… So be it! You shall be the Fellowship of the Ring.");
}

/*
 //why My LINQ is not working here??
var phoneCallUsers = from user in User.users
                     where ContactService.Factory.ContainsKey(ContactMethod.PhoneCall)
                     orderby user.Name
                     select user;


foreach (var user in phoneCallUsers)
{
    user.Contact("This call is very important to all the people. Please stay connected.");
}
*/