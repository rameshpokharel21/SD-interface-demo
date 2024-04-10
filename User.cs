
public class User
{
    public string Name { get; set; }
    public Location Location { get; set; }
    public bool IsFellowshipMember { get; set; }


    /*This field allows a user instance to have any one of the contact methods preferred
    Any class that implements IContactService may have an instance stored in _contactService
    Other classes don't have/need to know which and the user may change it at any time:*/
    private IContactService _contactService;


    public User(string name, Location location, ContactMethod contactPreference)
    {
        Name = name;
        Location = location;

        // When the user is instantiated, the preferred contact service is created:
        SelectContactMethod(contactPreference);
    }

    public void SelectContactMethod(ContactMethod preference)
    {
        _contactService = ContactService.Factory[preference]();
    }
    public void Contact(string message)
    {
        _contactService.Send(message, Name);
    }

    /*This list is static so that it belongs to the class, not any individual instance
    Take note that its existence and values have no bearing on the rest of the class:*/
    public static List<User> users = new List<User>()
    {
        new User("Merry", Location.TheShire, ContactMethod.Text) { IsFellowshipMember = true },
        new User("Pippin", Location.TheShire, ContactMethod.Email) { IsFellowshipMember = true },
        new User("Samwise", Location.TheShire, ContactMethod.Text) { IsFellowshipMember = true },
        new User("Frodo", Location.TheShire, ContactMethod.Email) { IsFellowshipMember = true },
        new User("Bilbo", Location.Rivendell, ContactMethod.Text),
        new User("Arwen", Location.Rivendell, ContactMethod.Text),
        new User("Elrond", Location.Rivendell, ContactMethod.Text),
        new User("Aragorn", Location.Rivendell, ContactMethod.Email) { IsFellowshipMember = true },
        new User("Legolas", Location.Mirkwood, ContactMethod.Text) { IsFellowshipMember = true },
        new User("Thranduil", Location.Mirkwood, ContactMethod.Text),
        new User("Boromir", Location.Gondor, ContactMethod.Text) { IsFellowshipMember = true },
        new User("Faramir", Location.Gondor, ContactMethod.Text),
        new User("Denethor", Location.Gondor, ContactMethod.Text),
        new User("Eowyn", Location.Rohan, ContactMethod.Text),
        new User("Theoden", Location.Rohan, ContactMethod.Text),
        new User("Eomer", Location.Rohan, ContactMethod.Text),
        new User("Galadriel", Location.Lothlorian, ContactMethod.Text),
        new User("Celeborn", Location.Lothlorian, ContactMethod.Text),
        new User("Thorin", Location.Erebor, ContactMethod.Text),
        new User("Gloin", Location.Erebor, ContactMethod.Email),
        new User("Gimli", Location.Erebor, ContactMethod.Text) { IsFellowshipMember = true },
        new User("Gandalf", Location.Isengard, ContactMethod.Email) { IsFellowshipMember = true },
        new User("Saruman", Location.Isengard, ContactMethod.Text),
        new User("Sauron", Location.Mordor, ContactMethod.Text),
        new User("Kris", Location.Rohan, ContactMethod.PhoneCall),
        new User("Thomas", Location.Isengard, ContactMethod.PhoneCall){IsFellowshipMember= true}
    };
}
