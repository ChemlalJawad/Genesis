﻿using System;
using System.Collections.Generic;
using System.Text;
using Genesis.Core.Domaine;

namespace Genesis.Service.Entreprises
{
    public class CreateEntrepriseCommand
    {
        public ICollection<Adresse> Adresses { get; set; }
        public string NumeroTva { get; set; }
        public Adresse SiegeSocial { get; set; }


    }
}
