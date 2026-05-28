using StudentBinding.Models;

namespace StudentBinding
{
    public partial class MainPage : ContentPage
    {
        Student student1;
        Student student2;
        public MainPage()
        {
            InitializeComponent();
            student1 = new Student
            {
                Image = "daniel.png",
                Name = "daniel",
                Age = 17,
                Date = new DateTime(2009, 11, 28),
                Mail = "daniel123@gmail.com",
                Phone = "856876"
            };
            student2 = new Student
            {
                Image ="noa.png",
                Name = "noa",
                Age = 16,
                Date = new DateTime(2008,5,6),
                Mail = "noa2145@gmail.com",
                Phone = "048726"
            };
            this.BindingContext = student1;
        }
        private void OnSwitchStudentClicked(object sender, EventArgs e)
        {
            if (this.BindingContext == student1)
            {
                this.BindingContext = student2;
            }
            else
            {
                this.BindingContext = student1;
            }
        }

    }
}
