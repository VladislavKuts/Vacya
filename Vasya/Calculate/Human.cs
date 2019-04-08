namespace Calculate
{
    internal class Human : Person
    {
        double _hungry = 8;
        public double hasEat = 0;
        public double hasDrink = 0;

        public double WhatHungryIs()
        {
            return this._hungry;
        }

        public void Eat(double eatenApples)
        {
            this._hungry = new CalcCore().MinusMethod(this._hungry, eatenApples);
            this.hasEat = this.hasEat + eatenApples;
        }



        //----------------------------------------------WATER-------------------------------------------------------------


        public double _litersOfWaterDrunked;

        public void Drink(double amountOfLiters)
        {
            this.hasDrink = this.hasDrink + amountOfLiters;
        }

    }
}