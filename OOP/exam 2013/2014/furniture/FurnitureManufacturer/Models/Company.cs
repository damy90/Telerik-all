namespace FurnitureManufacturer.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using FurnitureManufacturer.Interfaces;
    using System.Text;

    class Company : ICompany
    {
        private string name;
        private string registrationNumber;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.Furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty or null");
                }

                if (value.Length < 5)
                {
                    throw new ArgumentException("Name cannot be with less than 5 symbols");
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            set
            {
                if (!(value.Length == 10 && IsDigitsOnly(value)))
                {
                    throw new ArgumentException("Registration number must be exactly 10 symbols and must contain only digits. ");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures { get; private set; }

        public void Add(IFurniture furniture)
        {
            //TODO: check for null
            this.Furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.Furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.Furnitures.FirstOrDefault(x => x.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            var furnitures = this.Furnitures.OrderBy(x => x.Price)
                .ThenBy(x => x.Model)
                .ToList();
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("{0} - {1} - {2} {3}",
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture"));

            for (int i = 0; i < furnitures.Count; i++ )
            {
                result.AppendLine();
                result.Append(furnitures[i].ToString());
                //if (i < furnitures.Count - 1)
                //{
                //    result.AppendLine();
                //}
            }

            return result.ToString().TrimEnd();
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
