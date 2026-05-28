using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StudentBinding.Models
{
    internal class ObservableObject : INotifyPropertyChanged
    {
        //לפי מה שהבנתי המחלקה הזאת אמורה להיות מחלקה ש"צועקת" למחלקת סטודנטים כל פעם שתכונה כמו השם משתנה
        public event PropertyChangedEventHandler? PropertyChanged;//יצירת האיוונט שאחראי על להודיע על מה שהשתנה
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //הכפתור עצמו שמפעיל את הצופר
        }
        //פעולה שמפעילה את הצופר שדיברנו עליו
    }
}
