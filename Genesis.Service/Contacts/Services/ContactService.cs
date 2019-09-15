﻿using System;
using System.Collections.Generic;
using System.Text;
using Genesis.Core.Domaine;
using Genesis.Service.Contacts.Services.Interfaces;
using Genesis.Data.Repositories.Interfaces;

namespace Genesis.Service.Contacts.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        public ContactService(IContactRepository contactRepository) {
            _contactRepository = contactRepository;
        }
        public Contact Create(CreateContactCommand command)
        {
            var contact = new Contact
            {  
                 Adresse = command.Adresse,
                 TypeContact = command.TypeContact,
                 NumeroTva = command.NumeroTva
            };
            _contactRepository.CreateContact(contact);
            return contact;
        }

        public void Delete(int Id)
        {
            var contact = _contactRepository.ContactById(Id);
            _contactRepository.DeleteContact(contact);
        }

        public IEnumerable<Contact> GetAll()
        {
            var contacts = _contactRepository.GetAll();
            return contacts;
        }
    }
}
