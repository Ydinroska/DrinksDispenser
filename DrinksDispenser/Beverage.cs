using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DrinksDispenser
{
    internal class Beverage
    {

        public enum ContainerType
        {
            Glassbottle,
            Plasticbottle,
            Tin
        }

        private string productName;
        public string ProductName { get { return productName; } }


        private float volume;
        public float Volume {  get { return volume; } }

        private string flavour;
        public string Flavour { get {return flavour; } }


        private float price;     // HIDDEN AND PRIVATE
        public float Price { get { return price; } set {price = value; } }
       

        private ContainerType containerType;
        private bool hasIce;
        public bool HasIce => hasIce;

        public Beverage(
            string productName, 
            string flavour,
            float price,
            ContainerType containerType,
            float volume = 0.33f,
            bool hasIce = false
            )
        {
            this.productName = productName;
            this.volume = volume;
            this.flavour = flavour;
            this.price = price;
            this.containerType = containerType;
            this.hasIce = hasIce;
        }

        public override string ToString()
        {
            return $"Name: {productName}. Price: {price}. Volume: {volume}.";
        }

        





    }
}
