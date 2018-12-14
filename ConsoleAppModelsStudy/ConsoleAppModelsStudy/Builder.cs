using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModelsStudy
{
    public class Builder
    {
        public String name;
        public int number = -1;
        public String sex;
        public int age = -1;
        public String school;
        public Builder setName(String name)
        {
            this.name = name;
            return this;
        }

        public Builder setNumber(int number)
        {
            this.number = number;
            return this;
        }

        public Builder setSex(String sex)
        {
            this.sex = sex;
            return this;
        }

        public Builder setAge(int age)
        {
            this.age = age;
            return this;
        }

        public Builder setSchool(String school)
        {
            this.school = school;
            return this;
        }
        public Student build()
        {
            return new Student(this);
        }
    }
    public class Student
    {
         String name;
         int number = -1;
         String sex;
         int age = -1;
         String school;


         public Student(Builder builder)
        {

            this.age = builder.age;
            this.name = builder.name;
            this.number = builder.number;
            this.school = builder.school;
            this.sex = builder.sex;
        }
    }
    //构建器，利用构建器作为参数来构建Student对象
   
}
