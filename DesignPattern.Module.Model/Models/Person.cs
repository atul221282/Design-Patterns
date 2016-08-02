using System;
using DesignPattern.Module.Model.Interfaces;
using System.Collections.Generic;

namespace DesignPattern.Module.Model
{
    public class Person : IUser
    {
        private string name;
        private string surname;
        public IList<IContactInfo> Contacts { get; } = new List<IContactInfo>();
        public IContactInfo PrimaryContact { get; set; }

        public Person()
        {

        }

        public Person(string name, string surname)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
                throw new ArgumentException();

            this.Name = name;
            this.Surname = surname;
        }

        public void SetIdentity(IUserIdentity identity)
        {
            // identity must be IdentityCard
            // access identity.SSN
            IdentityCard id = identity as IdentityCard;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("First name must be non-empty.");
                this.name = value;
            }
        }

        public string Surname
        {
            get { return this.surname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Last name must be non-empty;");
                this.surname = value;
            }
        }

        public override string ToString() => $"{this.Name} {this.Surname}";

        public bool CanAccpetIdentity(IUserIdentity identity) => identity is IdentityCard;

        public void Add(IContactInfo contact)
        {
            if (contact == null)
                throw new ArgumentNullException();
            if (this.Contacts.Contains(contact))
                throw new ArgumentException();

            this.Contacts.Add(contact);
        }

        public void SetPrimaryContact(IContactInfo contact)
        {
            if (contact == null)
                throw new ArgumentNullException();
            if (!this.Contacts.Contains(contact))
                throw new ArgumentException();

            this.PrimaryContact = contact;
        }
    }
}
