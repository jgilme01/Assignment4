﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Contact
{
    public int ContactKey { get; set; }
    public string ContactNumber { get; set; }
    public Nullable<int> ContactTypeKey { get; set; }
    public Nullable<int> PersonKey { get; set; }

    public virtual Person Person { get; set; }
}

public partial class Donation
{
    public int DonationKey { get; set; }
    public Nullable<int> PersonKey { get; set; }
    public System.DateTime DonationDate { get; set; }
    public decimal DonationAmount { get; set; }
    public Nullable<System.Guid> DonationConfirmation { get; set; }

    public virtual Person Person { get; set; }
}

public partial class LoginHistoryTable
{
    public int LoginHistoryKey { get; set; }
    public Nullable<int> PersonKey { get; set; }
    public System.DateTime LoginTimeStamp { get; set; }

    public virtual Person Person { get; set; }
}

public partial class Person
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Person()
    {
        this.Contacts = new HashSet<Contact>();
        this.Donations = new HashSet<Donation>();
        this.LoginHistoryTables = new HashSet<LoginHistoryTable>();
        this.PersonAddresses = new HashSet<PersonAddress>();
    }

    public int PersonKey { get; set; }
    public string PersonLastName { get; set; }
    public string PersonFirstName { get; set; }
    public string PersonEmail { get; set; }
    public byte[] PersonPassWord { get; set; }
    public System.DateTime PersonEntryDate { get; set; }
    public Nullable<int> PersonPassWordSeed { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Contact> Contacts { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Donation> Donations { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<LoginHistoryTable> LoginHistoryTables { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
}

public partial class PersonAddress
{
    public int PersonAddressKey { get; set; }
    public string PersonAddressApt { get; set; }
    public string PersonAddressStreet { get; set; }
    public string PersonAddressCity { get; set; }
    public string PersonAddressState { get; set; }
    public string PersonAddressZip { get; set; }
    public Nullable<int> PersonKey { get; set; }

    public virtual Person Person { get; set; }
}
