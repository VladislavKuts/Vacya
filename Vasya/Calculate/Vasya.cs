namespace Calculate
{
    internal class Vasya : Human
    {
        public double apples;
        internal double amountOfLitersWater;

        public void VasyaEat(double eaten)
        {
            this.Eat(eaten);
            apples = this.apples - eaten;
        }

        public void VasyaDrink(double amountOfLiters)
        {
            this.Drink(amountOfLiters);
            amountOfLitersWater = this.amountOfLitersWater - amountOfLiters;
        }

    }
}