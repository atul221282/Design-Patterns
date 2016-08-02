﻿using DesignPattern.Module.Two.Interfaces;
using DesignPattern.Module.Two.Models;
using System;
using System.Collections.Generic;

namespace DesignPattern.Module.Two
{
    public class MachineFactory : IUserFactory
    {

        private Dictionary<string, Producer> NameToProducer { get; }

        public MachineFactory(Dictionary<string, Producer> nameToProducer)
        {
            if (nameToProducer == null)
                throw new ArgumentNullException(nameof(nameToProducer));
            this.NameToProducer = nameToProducer;
        }

        private Producer GetProducer(string name)
        {
            Producer producer;
            if (!this.NameToProducer.TryGetValue(name, out producer))
                throw new ArgumentException();
            return producer;
        }

        public IUser CreateUser(string name1, string name2)
        {
            Producer producer = this.GetProducer(name1);
            return new Machine(producer, name2);
        }

        public IUserIdentity CreateIdentity()
        {
            return new MacAddress();
        }
    }
}
