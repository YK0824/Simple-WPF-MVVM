# Simple WPF MVVM
 Use WPF to build a simple MVVM architecture  
Model–view–viewmodel (MVVM) is a software architectural pattern that facilitates the separation of the development of the graphical user interface (the view) – be it via a markup language or GUI code – from the development of the business logic or back-end logic (the model) so that the view is not dependent on any specific model platform.  
MVVM information Can see more in <https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93viewmodel>  
###### In the Model
Add witch you want the item model  
```C#
class ID_model
{
	public string Student_Name { get; set; }
	public int Student_ID { get; set; }
}
```
###### Create the ViewModel
This will help you to control the UI or Model  
```C#
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
```
Before all the event create, I need to add the source.  
-->INotifyPropertyChanged  
In the previous tutorial, you learned how to create an event handler and attach it to an event, such as the clicking of a button.  
Your class will need to implement the INotifyPropertyChanged interface.  
```C#
class ID_viewmodel : INotifyPropertyChanged
{
	public event PropertyChangedEventHandler PropertyChanged;
	protected void OnPropertyChange(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
```
And then, this is the simple WPF MVVM. Learning~