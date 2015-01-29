﻿using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;

namespace CSM.Socrata.Models
{
    /// <summary>
    /// Defines a global site-settings part for Socrata connection information.
    /// </summary>
    public class SocrataSettingsPart : ContentPart
    {
        private readonly ComputedField<string> _password = new ComputedField<string>();

        public ComputedField<string> PasswordField
        {
            get { return _password; }
        }

        public string Password
        {
            get { return PasswordField.Value; }
            set { PasswordField.Value = value; }
        }

        public string Host
        {
            get { return Retrieve<string>("Host"); }
            set { Store<string>("Host", value); }
        }

        public string Username
        {
            get { return Retrieve<string>("Username"); }
            set { Store<string>("Username", value); }
        }
    }
}