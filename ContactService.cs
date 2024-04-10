
using InterfaceDemo;

public static class ContactService
{
    public static readonly IReadOnlyDictionary<ContactMethod, Func<IContactService>> Factory = new Dictionary<ContactMethod, Func<IContactService>>
    {
        { ContactMethod.Email, () => new Emailer() },
        { ContactMethod.Text, () => new TextMessager() },
        // Add contact methods here
        {ContactMethod.PhoneCall, () => new PhoneCaller() }
    };
}