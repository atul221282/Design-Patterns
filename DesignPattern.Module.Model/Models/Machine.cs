using System;
using DesignPattern.Module.Model.Interfaces;

namespace DesignPattern.Module.Model
{
    public class Machine : IUser
    {
        public Producer Producer { get; set; }
        public string Model { get; set; }

        public Machine()
        {

        }
        public Machine(Producer producer, string model)
        {
            if (producer == null)
                throw new ArgumentNullException();

            if (string.IsNullOrEmpty(model))
                throw new ArgumentException();

            this.Producer = producer;
            this.Model = model;

        }

        public void SetIdentity(IUserIdentity identity)
        {
            // identity must be MacAddress
            // access identity.NicPart
        }

        public bool CanAccpetIdentity(IUserIdentity identity)
        {
            throw new NotImplementedException();
        }

        public void Add(IContactInfo contact)
        {
            throw new NotImplementedException();
        }

        public void SetPrimaryContact(IContactInfo contact)
        {
            throw new NotImplementedException();
        }
    }
}
