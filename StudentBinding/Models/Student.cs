using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBinding.Models
{
    internal class Student : ObservableObject
    {
        private string image;
        public string Image
        {
            get { return image; }
            set
            {
                if (image != value)
                {
                    image = value;
                    OnPropertyChanged();
                }
            }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set 
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (age != value)
                {
                    age = value;
                    OnPropertyChanged();
                }
            }
        }
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set 
            {
                if (date != value)
                {
                    date = value;
                    OnPropertyChanged();
                }
            }
        }
        private string mail;
        public string Mail
        {
            get { return mail; }
            set
            {
                if (mail != value)
                {
                    mail = value;
                    OnPropertyChanged();
                }
            }
        }
        private string phone;
        public string Phone
        {
            get { return phone; }
            set
            {
                if (phone != value)
                {
                    phone = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}
