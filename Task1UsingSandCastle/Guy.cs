// -----------------------------------------------------------------------
// <copyright file="Guy.cs" company="D">
// TODO: Update copyright text.
// </copyright>
// <summary>This is the Guy class.</summary>
// -----------------------------------------------------------------------
namespace Task1UsingSandCastle
{
    using System;
    
    /// <summary>
    /// A guy with a name, age and a wallet full of bucks.
    /// </summary>
    public class Guy
    {
        /// <summary>
        /// Backing field for the Name property.
        /// </summary>
        private string name;

        /// <summary>
        /// Backing field for the Name property.
        /// </summary>
        private int age;

        /// <summary>
        /// Initializes a new instance of the Guy class.
        /// </summary>
        /// <param name="name">The name of the guy.</param>
        /// <param name="age">The guy's age.</param>
        /// <param name="cash">The amount of cash the guy starts with.</param>
        public Guy(string name, int age, int cash)
        {
            this.Name = name;
            this.Age = age;
            this.Cash = cash;
        }
        
        /// <summary>
        /// Gets or sets the guy's age.
        /// </summary>
        /// <value> Age of guy.</value>
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        /// <summary>
        /// Gets the number of bucks the guy has.
        /// </summary>
        /// <value> Number of bucks the guy has.</value>
        public int Cash { get; private set; }

        /// <summary>
        /// Gets or sets the name of the guy.
        /// </summary>
        /// <value> The name of the guy.</value>
        public string Name 
        { 
            get { return this.name; }
            set { this.name = value; } 
        }

        /// <summary>
        /// Represent the Guy like a string.
        /// </summary>
        /// <returns> Guy like a string.</returns>
        public override string ToString()
        {
            return string.Format("{0} is {1} years old and has {2} bucks", this.Name, this.Age, this.Cash);
        }

        /// <summary>
        /// Give cash from my wallet.
        /// </summary>
        /// <param name="amount">The amount of cash to give.</param>
        /// <returns>The amount of cash I gave, or 0 if I don't have enough cash.</returns>
        public int GiveCash(int amount)
        {
            if (amount <= this.Cash && amount > 0)
            {
                this.Cash -= amount;
                return amount;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Receive some cash into my wallet.
        /// </summary>
        /// <param name="amount">Amount to receive.</param>
        /// <returns>The amount of cash received, or 0 if no cash was received.</returns>
        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                if (amount > 0)
                {
                    this.Cash += amount;
                    return amount;
                }

                Console.WriteLine("{0} says: {1} isn't an amount I'll take", this.Name, amount);
            }

            return 0;
        }
    }
}
