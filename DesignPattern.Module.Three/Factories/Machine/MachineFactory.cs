﻿using System;
using System.Collections.Generic;
using DesignPattern.Module.Three.Factories.Interfaces;
using DesignPattern.Module.Three.Interfaces;
using DesignPattern.Module.Three.Models;

namespace DesignPattern.Module.Three.Factories.Machine
{
    public class MachineFactory: IUserFactory
    {
        private Dictionary<string, Producer> NameToProducer { get; }

        public MachineFactory(Dictionary<string, Producer> nameToProducer)
        {
            if (nameToProducer == null)
                throw new ArgumentNullException();
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
            Producer producer = GetProducer(name1);
            return new Models.Machine(producer, name2);
        }

        public IUserIdentity CreateIdentity()
        {
            return new MacAddress();
        }
    }
}
