using DesignPattern.AbstractFactory.Builder.Person.Interfaces;
using DesignPattern.AbstractFactory.Common;
using DesignPattern.Module.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model = DesignPattern.Module.Model;
namespace DesignPattern.AbstractFactory.Builder.Person
{
    public class PersonBuilder :
        IFirstNameHolder, ILastNameHolder, IPrimaryContactHolder, IContactHolder, IPersonBuilder
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private INonEmptyStringState FirstNameState { get; set; } = new UninitializedString();
        private INonEmptyStringState LastNameState { get; set; } = new UninitializedString();

        private IList<IContactInfo> Contacts { get; } = new List<IContactInfo>();

        public void SetPrimaryContact(IContactInfo contact)
        {
            this.PrimaryContact = contact;
        }
        public IContactInfo PrimaryContact { get; set; }
        public void SetFirstName(string firstName)
        {
            this.FirstNameState = this.FirstNameState.Set(firstName);
        }
        public void SetLastName(string lastName)
        {
            //this.LastName = lastName;
            this.LastNameState = this.LastNameState.Set(lastName);
        }
        public IContactHolder Add(IContactInfo contact)
        {
            if (contact == null)
                throw new ArgumentNullException();
            if (this.Contacts.Contains(contact))
                throw new ArgumentException();

            this.Contacts.Add(contact);

            return this;
        }
        public Model.Person Build()
        {
            Model.Person person = new Model.Person(this.FirstNameState.Get(), this.LastNameState.Get());

            foreach (IContactInfo contact in this.Contacts)
                person.Add(contact);

            person.SetPrimaryContact(this.PrimaryContact);

            return person;
        }

        public ILastNameHolder WithFirstName(string name)
        {
            this.FirstNameState = this.FirstNameState.Set(name);
            return this;
        }

        public bool IsValidFirstName(string name)
        {
            throw new NotImplementedException();
        }

        public IPrimaryContactHolder WithLastName(string surname)
        {
            this.LastNameState = this.LastNameState.Set(surname);
            return this;
        }

        public bool IsValidLastName(string surname)
        {
            throw new NotImplementedException();
        }

        public IContactHolder WithPrimaryContact(IContactInfo contact)
        {
            this.Contacts.Add(contact);
            this.PrimaryContact = contact;
            return this;
        }

        public bool Contains(IContactInfo contact)
        {
            throw new NotImplementedException();
        }

        public IPersonBuilder NoMoreContacts()
        {
            return this;
        }
    }
}
