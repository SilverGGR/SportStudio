using System;
using System.ComponentModel;

namespace SportStudio
{
    public class User : INotifyPropertyChanged
    {
        private string email;
        private string password;
        private string firstName;
        private string lastName;
        private string street;
        private int streetNumber;
        private string city;
        private int postalCode;

        public Membership UserMembership { get; set; }

#pragma warning disable CS8618 // Ein Non-Nullable-Feld muss beim Beenden des Konstruktors einen Wert ungleich NULL enthalten. Erwägen Sie die Deklaration als Nullable.
        public User(
#pragma warning restore CS8618 // Ein Non-Nullable-Feld muss beim Beenden des Konstruktors einen Wert ungleich NULL enthalten. Erwägen Sie die Deklaration als Nullable.
            string email,
            string password,
            string firstName,
            string lastName,
            string street,
            int streetNumber,
            string city,
            int postalCode
            )
        {
            this.Id = Guid.NewGuid();
            this.Email = email;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Street = street;
            this.StreetNumber = streetNumber;
            this.City = city;
            this.PostalCode = postalCode;

            this.UserMembership = new Membership(false, false, false, false, 0);
        }

        public virtual void DisplayMembershipInfo()
        {
            MessageBox.Show($"Sie haben eine normale Mitgliedschaft\nMukiBude: {UserMembership.MukiAbo}\nCardio: {UserMembership.CardioAbo}\nWasser: {UserMembership.WasserAbo}\nWellnessoase: {UserMembership.WellnessAbo}");
        }

        public void ShowAttributes()
        {
            MessageBox.Show($"Email: {Email}\nPassword: {Password}\nFirstName: {FirstName}\nLastName: {LastName}\nStreet: {Street}\nStreetNumber: {StreetNumber}\nCity: {City}\nPostalCode: {PostalCode}");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Guid Id { get; }

        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(nameof(Email)); }
        }

        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(nameof(Password)); }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; OnPropertyChanged(nameof(FirstName)); }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged(nameof(LastName)); }
        }

        public string Street
        {
            get { return street; }
            set { street = value; OnPropertyChanged(nameof(Street)); }
        }

        public int StreetNumber
        {
            get { return streetNumber; }
            set { streetNumber = value; OnPropertyChanged(nameof(StreetNumber)); }
        }

        public string City
        {
            get { return city; }
            set { city = value; OnPropertyChanged(nameof(City)); }
        }

        public int PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; OnPropertyChanged(nameof(PostalCode)); }
        }
    }
}
