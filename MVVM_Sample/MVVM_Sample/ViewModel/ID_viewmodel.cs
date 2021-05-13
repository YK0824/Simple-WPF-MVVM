using MVVM_Sample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Sample.ViewModel
{
    class ID_viewmodel : INotifyPropertyChanged
    {
        private ID_model _model;
        public ID_viewmodel()
        {
            _model = new ID_model
            {
                Student_Name = "YK Leo",
                Student_ID = 620114
            };
        }

        public string Student_Name
        {
            get { return _model.Student_Name; }
            set
            {
                if (_model.Student_Name != value)
                {
                    _model.Student_Name = value;
                    OnPropertyChange("Student_Name");
                    OnPropertyChange("FullName_ID");
                }
            }
        }
        public int Student_ID
        {
            get { return _model.Student_ID; }
            set
            {
                if (_model.Student_ID != value)
                {
                    _model.Student_ID = value;
                    OnPropertyChange("Student_Name");
                    OnPropertyChange("FullName_ID");

                }
            }
        }
        public string FullName_ID
        {
            get { return "Name: " + Student_Name + "; ID: " + Student_ID;    }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
