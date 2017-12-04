using System;
using System.Collections.Generic;
using System.Text;
using static ITLec.DesignPattern.Creational.Builder.Enums;

namespace ITLec.DesignPattern.Creational.Builder
{
   public  class BasicInfoBuilder: WorkerBuilder
    {

        public BasicInfoBuilder(Worker worker)
        {
            this.worker = worker;
        }

        public BasicInfoBuilder FullName(string fullName)
        {
            worker.FullName = fullName;

            return this;
        }

        public BasicInfoBuilder Gender(Gender gender)
        {
            worker.Gender = gender;

            return this;
        }


        public BasicInfoBuilder Nationality(Country nationality)
        {
            worker.Nationality = nationality;

            return this;
        }



        public BasicInfoBuilder Birthdate(DateTime birthdate)
        {
            worker.Birthdate = birthdate;

            return this;
        }

    }
}
